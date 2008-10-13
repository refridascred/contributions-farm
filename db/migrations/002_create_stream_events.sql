-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (ratio, active, score, label, weight) VALUES (76.17, 85, 14.02, 'eu-west', 38.88);
INSERT INTO stream_events (ratio, active, score, label, weight) VALUES (60.33, 57, 95.12, 'edge', 45.12);
