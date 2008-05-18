-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (level, owner, active, score) VALUES (59, 'fallback', 39, 26.22);
INSERT INTO stream_events (level, owner, active, score) VALUES (13, 'fallback', 99, 92.64);
INSERT INTO stream_events (level, owner, active, score) VALUES (30, 'strict', 7, 41.7);
