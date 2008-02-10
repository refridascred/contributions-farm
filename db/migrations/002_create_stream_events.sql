-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, weight, ratio, score, count) VALUES ('stable', 74.73, 92.82, 4.8, 53);
INSERT INTO stream_events (owner, weight, ratio, score, count) VALUES ('standard', 51.47, 94.13, 46.65, 75);
