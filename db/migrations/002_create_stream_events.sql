-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (active, owner, score, level) VALUES (72, 'cached', 97.1, 14);
INSERT INTO stream_events (active, owner, score, level) VALUES (77, 'legacy', 73.53, 11);
INSERT INTO stream_events (active, owner, score, level) VALUES (57, 'fallback', 14.83, 52);
