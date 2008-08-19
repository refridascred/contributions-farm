-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (state, token, owner, score) VALUES ('edge', 'open', 'cached', 96.27);
INSERT INTO stream_events (state, token, owner, score) VALUES ('standard', 'stable', 'fallback', 55.57);
