-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (rank, token, state) VALUES (78, 'fallback', 'stable');
INSERT INTO stream_events (rank, token, state) VALUES (67, 'blue', 'fallback');
INSERT INTO stream_events (rank, token, state) VALUES (27, 'primary', 'local');
