-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (active, state, label, count) VALUES (42, 'strict', 'fallback', 41);
INSERT INTO stream_events (active, state, label, count) VALUES (86, 'cached', 'open', 1);
INSERT INTO stream_events (active, state, label, count) VALUES (28, 'blue', 'edge', 32);
