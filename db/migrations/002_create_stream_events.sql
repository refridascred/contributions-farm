-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, state, ratio, active) VALUES ('stable', 'legacy', 91.46, 61);
INSERT INTO stream_events (token, state, ratio, active) VALUES ('fallback', 'strict', 7.08, 64);
