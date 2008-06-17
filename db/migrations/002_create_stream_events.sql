-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (owner, score, state, count, level) VALUES ('cached', 57.01, 'blue', 59, 64);
INSERT INTO stream_events (owner, score, state, count, level) VALUES ('green', 16.45, 'primary', 30, 56);
INSERT INTO stream_events (owner, score, state, count, level) VALUES ('staging', 67.11, 'edge', 54, 46);
