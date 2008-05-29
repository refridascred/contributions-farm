-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (rank, score, count, owner) VALUES (23, 3.51, 96, 'cached');
