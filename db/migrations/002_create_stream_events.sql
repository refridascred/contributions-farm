-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (weight, owner, score, state, active) VALUES (23.52, 'edge', 79.94, 'blue', 7);
INSERT INTO stream_events (weight, owner, score, state, active) VALUES (66.39, 'latest', 70.75, 'edge', 64);
