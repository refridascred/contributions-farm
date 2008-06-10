-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (state, label, owner, token) VALUES ('standard', 'local', 'primary', 'fallback');
INSERT INTO stream_events (state, label, owner, token) VALUES ('standard', 'blue', 'green', 'edge');
