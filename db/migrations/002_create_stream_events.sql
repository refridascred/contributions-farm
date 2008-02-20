-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    created_at TIMESTAMP,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (label, level, token, owner) VALUES ('edge', 18, 'blue', 'stable');
INSERT INTO stream_events (label, level, token, owner) VALUES ('local', 70, 'stable', 'strict');
