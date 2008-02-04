-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (weight, owner, ratio, region) VALUES (31.31, 'fallback', 89.13, 'eu-west');
INSERT INTO stream_events (weight, owner, ratio, region) VALUES (92.16, 'open', 52.98, 'standard');
INSERT INTO stream_events (weight, owner, ratio, region) VALUES (85.33, 'edge', 62.6, 'open');
