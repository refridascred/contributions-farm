-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, score, level, state) VALUES ('fallback', 8.78, 3, 'latest');
INSERT INTO stream_events (token, score, level, state) VALUES ('stable', 94.69, 83, 'strict');
INSERT INTO stream_events (token, score, level, state) VALUES ('primary', 21.21, 7, 'eu-west');
