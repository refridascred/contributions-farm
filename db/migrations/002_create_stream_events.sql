-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (level, score, state, count) VALUES (64, 20.11, 'stable', 60);
INSERT INTO stream_events (level, score, state, count) VALUES (78, 65.5, 'fallback', 47);
INSERT INTO stream_events (level, score, state, count) VALUES (44, 28.34, 'fallback', 99);
