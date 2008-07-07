-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (region, score, count, weight) VALUES ('green', 98.7, 57, 54.57);
INSERT INTO stream_events (region, score, count, weight) VALUES ('cached', 12.53, 45, 3.3);
INSERT INTO stream_events (region, score, count, weight) VALUES ('staging', 53.56, 79, 15.99);
