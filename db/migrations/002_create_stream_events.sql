-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (rank, score, state, count) VALUES (29, 28.63, 'stable', 95);
INSERT INTO stream_events (rank, score, state, count) VALUES (92, 21.05, 'staging', 59);
INSERT INTO stream_events (rank, score, state, count) VALUES (42, 39.08, 'open', 56);
