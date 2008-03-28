-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (weight, score, owner, rank) VALUES (24.02, 97.47, 'stable', 82);
INSERT INTO stream_events (weight, score, owner, rank) VALUES (48.99, 93.6, 'green', 73);
INSERT INTO stream_events (weight, score, owner, rank) VALUES (74.24, 86.05, 'standard', 83);
