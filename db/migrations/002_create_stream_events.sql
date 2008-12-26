-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (count, rank, ratio, score, token) VALUES (52, 86, 3.92, 75.58, 'legacy');
INSERT INTO stream_events (count, rank, ratio, score, token) VALUES (54, 83, 29.54, 21.52, 'local');
