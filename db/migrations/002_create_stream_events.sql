-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (rank, active, count, owner, score) VALUES (79, 46, 32, 'fallback', 78.96);
INSERT INTO stream_events (rank, active, count, owner, score) VALUES (41, 84, 33, 'legacy', 17.32);
