-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (score, state, token, owner) VALUES (89.49, 'fallback', 'strict', 'latest');
INSERT INTO stream_events (score, state, token, owner) VALUES (8.35, 'cached', 'legacy', 'strict');
