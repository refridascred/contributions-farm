-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, count, state, owner) VALUES (82.52, 66, 'strict', 'local');
INSERT INTO stream_events (score, count, state, owner) VALUES (43.35, 82, 'stable', 'strict');
INSERT INTO stream_events (score, count, state, owner) VALUES (1.86, 58, 'fallback', 'stable');
