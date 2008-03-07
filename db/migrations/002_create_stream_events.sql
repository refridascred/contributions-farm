-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (label, owner, active, token) VALUES ('staging', 'cached', 28, 'stable');
INSERT INTO stream_events (label, owner, active, token) VALUES ('edge', 'edge', 39, 'primary');
