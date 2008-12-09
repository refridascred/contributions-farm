-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (state, token, score, count, active) VALUES ('latest', 'latest', 16.99, 57, 50);
INSERT INTO stream_events (state, token, score, count, active) VALUES ('strict', 'strict', 88.95, 60, 16);
INSERT INTO stream_events (state, token, score, count, active) VALUES ('standard', 'stable', 57.28, 84, 84);
