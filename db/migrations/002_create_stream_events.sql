-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (weight, active, score, owner) VALUES (62.05, 81, 76.15, 'standard');
INSERT INTO stream_events (weight, active, score, owner) VALUES (46.2, 91, 33.19, 'primary');
