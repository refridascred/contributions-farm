-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    region TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (ratio, region, rank, score) VALUES (79.35, 'eu-west', 58, 52.64);
INSERT INTO stream_events (ratio, region, rank, score) VALUES (66.88, 'green', 53, 96.54);
