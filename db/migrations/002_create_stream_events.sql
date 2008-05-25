-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, level, state, token, region) VALUES (0.88, 59, 'stable', 'latest', 'fallback');
INSERT INTO stream_events (weight, level, state, token, region) VALUES (73.3, 37, 'latest', 'green', 'strict');
