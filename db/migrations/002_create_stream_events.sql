-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (token, count, state, rank, active) VALUES ('green', 63, 'staging', 84, 59);
INSERT INTO stream_events (token, count, state, rank, active) VALUES ('primary', 61, 'legacy', 58, 49);
INSERT INTO stream_events (token, count, state, rank, active) VALUES ('green', 11, 'stable', 34, 89);
