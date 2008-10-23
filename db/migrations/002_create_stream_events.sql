-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, state, token) VALUES (26, 'staging', 'standard');
INSERT INTO stream_events (rank, state, token) VALUES (61, 'open', 'fallback');
INSERT INTO stream_events (rank, state, token) VALUES (84, 'open', 'staging');
