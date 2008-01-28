-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    token TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (level, rank, token, owner, score) VALUES (53, 22, 'latest', 'latest', 50.85);
INSERT INTO stream_events (level, rank, token, owner, score) VALUES (79, 68, 'cached', 'fallback', 72.08);
