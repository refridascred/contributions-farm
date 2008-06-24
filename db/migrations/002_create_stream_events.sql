-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (state, owner, active, token) VALUES ('primary', 'legacy', 62, 'fallback');
INSERT INTO stream_events (state, owner, active, token) VALUES ('fallback', 'eu-west', 68, 'green');
INSERT INTO stream_events (state, owner, active, token) VALUES ('edge', 'legacy', 74, 'cached');
