-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, score) VALUES (2.6, 91.5);
INSERT INTO stream_events (weight, score) VALUES (93.0, 38.65);
INSERT INTO stream_events (weight, score) VALUES (17.21, 67.57);
