-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (token, region, score, rank) VALUES ('edge', 'strict', 65.36, 98);
INSERT INTO stream_events (token, region, score, rank) VALUES ('fallback', 'eu-west', 14.63, 18);
