-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    weight REAL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (owner, ratio, weight, score) VALUES ('standard', 72.28, 74.11, 25.27);
INSERT INTO stream_events (owner, ratio, weight, score) VALUES ('primary', 1.66, 48.49, 87.53);
