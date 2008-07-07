-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (state, token) VALUES ('legacy', 'fallback');
INSERT INTO stream_events (state, token) VALUES ('primary', 'fallback');
