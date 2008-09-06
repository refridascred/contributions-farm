-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (active, token, state, weight) VALUES (76, 'fallback', 'stable', 16.17);
INSERT INTO stream_events (active, token, state, weight) VALUES (89, 'cached', 'stable', 88.74);
