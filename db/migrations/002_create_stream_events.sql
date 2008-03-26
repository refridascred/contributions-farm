-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (level, state, score, count, token) VALUES (92, 'cached', 41.25, 90, 'stable');
INSERT INTO stream_events (level, state, score, count, token) VALUES (52, 'green', 49.48, 3, 'latest');
INSERT INTO stream_events (level, state, score, count, token) VALUES (69, 'open', 78.66, 75, 'primary');
