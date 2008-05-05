-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (active, label, score, state, token) VALUES (60, 'open', 79.1, 'edge', 'primary');
INSERT INTO stream_events (active, label, score, state, token) VALUES (3, 'blue', 93.58, 'local', 'blue');
INSERT INTO stream_events (active, label, score, state, token) VALUES (19, 'edge', 33.85, 'staging', 'local');
