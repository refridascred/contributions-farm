-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (active, region, rank, count, score) VALUES (91, 'green', 84, 69, 98.7);
INSERT INTO stream_events (active, region, rank, count, score) VALUES (60, 'open', 80, 86, 10.84);
INSERT INTO stream_events (active, region, rank, count, score) VALUES (42, 'staging', 35, 48, 76.78);
