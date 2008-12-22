-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (rank, score, active) VALUES (58, 4.73, 63);
INSERT INTO stream_events (rank, score, active) VALUES (32, 43.89, 25);
INSERT INTO stream_events (rank, score, active) VALUES (58, 70.68, 16);
