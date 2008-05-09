-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (ratio, score, active, owner) VALUES (12.69, 25.73, 87, 'eu-west');
INSERT INTO stream_events (ratio, score, active, owner) VALUES (13.51, 27.36, 97, 'primary');
INSERT INTO stream_events (ratio, score, active, owner) VALUES (0.95, 30.75, 31, 'strict');
