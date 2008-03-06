-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (weight, score) VALUES (83.45, 68.15);
INSERT INTO stream_events (weight, score) VALUES (2.48, 29.93);
INSERT INTO stream_events (weight, score) VALUES (69.18, 35.2);
