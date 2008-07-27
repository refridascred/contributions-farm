-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (state, score, owner, rank) VALUES ('fallback', 88.16, 'fallback', 42);
INSERT INTO stream_events (state, score, owner, rank) VALUES ('latest', 44.94, 'edge', 56);
