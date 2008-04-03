-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (label, level, active, state, token) VALUES ('green', 32, 92, 'green', 'strict');
INSERT INTO stream_events (label, level, active, state, token) VALUES ('green', 96, 96, 'blue', 'stable');
INSERT INTO stream_events (label, level, active, state, token) VALUES ('fallback', 96, 67, 'local', 'stable');
