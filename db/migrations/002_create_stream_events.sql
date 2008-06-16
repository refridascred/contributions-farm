-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, score, active) VALUES (43.48, 73.15, 54);
INSERT INTO stream_events (weight, score, active) VALUES (69.61, 34.04, 1);
INSERT INTO stream_events (weight, score, active) VALUES (40.53, 98.6, 23);
