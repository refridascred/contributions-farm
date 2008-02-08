-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, state, token, active) VALUES (0, 'staging', 'legacy', 19);
INSERT INTO stream_events (rank, state, token, active) VALUES (40, 'latest', 'strict', 97);
INSERT INTO stream_events (rank, state, token, active) VALUES (27, 'primary', 'eu-west', 47);
