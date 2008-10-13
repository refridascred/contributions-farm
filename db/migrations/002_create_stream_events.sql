-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, rank, weight, level) VALUES (12.32, 42, 53.0, 51);
INSERT INTO stream_events (score, rank, weight, level) VALUES (92.28, 14, 3.79, 89);
