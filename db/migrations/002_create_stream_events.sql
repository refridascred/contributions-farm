-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (token, active, weight, score) VALUES ('blue', 69, 49.3, 27.45);
INSERT INTO stream_events (token, active, weight, score) VALUES ('edge', 89, 67.6, 46.28);
INSERT INTO stream_events (token, active, weight, score) VALUES ('local', 76, 36.11, 6.5);
