-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, score, owner, token) VALUES (57, 89.78, 'fallback', 'strict');
INSERT INTO stream_events (level, score, owner, token) VALUES (7, 36.89, 'strict', 'standard');
