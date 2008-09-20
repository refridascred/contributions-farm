-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (ratio, token, rank, score) VALUES (70.68, 'legacy', 92, 54.48);
INSERT INTO stream_events (ratio, token, rank, score) VALUES (98.94, 'standard', 18, 88.77);
