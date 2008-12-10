-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (count, score, rank) VALUES (15, 35.35, 18);
INSERT INTO stream_events (count, score, rank) VALUES (82, 4.95, 24);
INSERT INTO stream_events (count, score, rank) VALUES (79, 70.32, 71);
