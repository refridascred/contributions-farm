-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (active, score, ratio, weight, owner) VALUES (31, 90.2, 60.65, 58.89, 'legacy');
INSERT INTO stream_events (active, score, ratio, weight, owner) VALUES (79, 79.23, 93.96, 93.92, 'staging');
INSERT INTO stream_events (active, score, ratio, weight, owner) VALUES (45, 59.8, 42.92, 27.8, 'legacy');
