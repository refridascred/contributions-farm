-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (owner, ratio, region) VALUES ('blue', 66.51, 'strict');
INSERT INTO stream_events (owner, ratio, region) VALUES ('blue', 24.95, 'cached');
INSERT INTO stream_events (owner, ratio, region) VALUES ('edge', 80.65, 'standard');
