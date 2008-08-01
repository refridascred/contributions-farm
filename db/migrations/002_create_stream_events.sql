-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (score, ratio, region, rank) VALUES (47.15, 63.56, 'legacy', 99);
INSERT INTO stream_events (score, ratio, region, rank) VALUES (18.2, 48.45, 'staging', 96);
