-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (score, state, level, token) VALUES (3.07, 'fallback', 78, 'local');
INSERT INTO stream_events (score, state, level, token) VALUES (94.45, 'strict', 70, 'latest');
