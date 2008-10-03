-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (count, score, active, weight) VALUES (64, 9.46, 5, 91.32);
INSERT INTO stream_events (count, score, active, weight) VALUES (52, 85.63, 53, 90.77);
INSERT INTO stream_events (count, score, active, weight) VALUES (14, 25.48, 56, 51.63);
