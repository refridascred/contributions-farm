-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (count, state, weight, owner, token) VALUES (67, 'strict', 34.48, 'blue', 'stable');
INSERT INTO stream_events (count, state, weight, owner, token) VALUES (58, 'stable', 79.96, 'cached', 'edge');
INSERT INTO stream_events (count, state, weight, owner, token) VALUES (13, 'stable', 50.69, 'staging', 'fallback');
