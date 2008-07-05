-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, ratio, count, token, rank) VALUES (61.8, 67.47, 95, 'open', 52);
INSERT INTO stream_events (score, ratio, count, token, rank) VALUES (25.52, 66.3, 76, 'latest', 93);
