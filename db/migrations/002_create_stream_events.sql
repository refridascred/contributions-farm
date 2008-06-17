-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (weight, active, score, ratio) VALUES (20.91, 89, 57.16, 80.15);
INSERT INTO stream_events (weight, active, score, ratio) VALUES (78.03, 20, 48.03, 1.75);
