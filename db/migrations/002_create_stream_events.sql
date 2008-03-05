-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (ratio, score, region) VALUES (6.51, 60.5, 'legacy');
INSERT INTO stream_events (ratio, score, region) VALUES (21.05, 68.68, 'eu-west');
INSERT INTO stream_events (ratio, score, region) VALUES (64.16, 42.99, 'cached');
