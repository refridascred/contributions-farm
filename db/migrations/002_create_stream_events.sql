-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (active, rank, weight, score, owner) VALUES (6, 58, 1.1, 36.07, 'stable');
INSERT INTO stream_events (active, rank, weight, score, owner) VALUES (12, 73, 49.12, 72.7, 'fallback');
