-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (rank, token, state) VALUES (47, 'open', 'primary');
INSERT INTO stream_events (rank, token, state) VALUES (72, 'fallback', 'staging');
INSERT INTO stream_events (rank, token, state) VALUES (1, 'strict', 'stable');
