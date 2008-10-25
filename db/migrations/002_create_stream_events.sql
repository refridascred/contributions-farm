-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    token TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (weight, region, token, rank, score) VALUES (26.37, 'staging', 'fallback', 96, 71.58);
INSERT INTO stream_events (weight, region, token, rank, score) VALUES (22.95, 'green', 'local', 95, 58.86);
