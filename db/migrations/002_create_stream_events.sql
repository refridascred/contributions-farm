-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (label, token, ratio, state, active) VALUES ('open', 'local', 83.89, 'stable', 97);
INSERT INTO stream_events (label, token, ratio, state, active) VALUES ('local', 'blue', 64.92, 'fallback', 77);
