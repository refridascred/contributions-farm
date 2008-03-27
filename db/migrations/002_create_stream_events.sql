-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (count, rank, state, score) VALUES (74, 3, 'legacy', 1.0);
INSERT INTO stream_events (count, rank, state, score) VALUES (88, 96, 'stable', 93.96);
INSERT INTO stream_events (count, rank, state, score) VALUES (69, 25, 'latest', 31.56);
