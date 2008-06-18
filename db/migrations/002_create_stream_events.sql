-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (level, token, state, score, rank) VALUES (94, 'primary', 'edge', 28.2, 19);
INSERT INTO stream_events (level, token, state, score, rank) VALUES (14, 'stable', 'fallback', 75.8, 16);
INSERT INTO stream_events (level, token, state, score, rank) VALUES (27, 'blue', 'stable', 23.28, 71);
