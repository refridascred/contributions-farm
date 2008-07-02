-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    weight REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, rank, weight, level, count) VALUES (21.82, 26, 8.08, 59, 19);
INSERT INTO stream_events (score, rank, weight, level, count) VALUES (78.85, 34, 8.16, 81, 10);
