-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (ratio, active, score, rank, region) VALUES (82.42, 35, 68.09, 88, 'eu-west');
INSERT INTO stream_events (ratio, active, score, rank, region) VALUES (12.05, 71, 39.56, 58, 'strict');
