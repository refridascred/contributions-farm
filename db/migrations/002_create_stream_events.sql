-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (label, score, region) VALUES ('blue', 14.16, 'strict');
INSERT INTO stream_events (label, score, region) VALUES ('strict', 41.74, 'blue');
INSERT INTO stream_events (label, score, region) VALUES ('local', 86.32, 'staging');
