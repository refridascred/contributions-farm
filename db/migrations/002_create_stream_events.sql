-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (owner, state, token, label) VALUES ('edge', 'cached', 'stable', 'staging');
INSERT INTO stream_events (owner, state, token, label) VALUES ('blue', 'edge', 'legacy', 'green');
