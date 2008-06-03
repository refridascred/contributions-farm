-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, state, active, rank, owner) VALUES (70.81, 'latest', 63, 4, 'stable');
INSERT INTO stream_events (score, state, active, rank, owner) VALUES (36.63, 'green', 96, 9, 'legacy');
