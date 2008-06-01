-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (token, rank, weight, score, count) VALUES ('edge', 21, 43.54, 70.65, 40);
