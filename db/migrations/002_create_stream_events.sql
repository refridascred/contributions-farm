-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (count, weight, label, ratio, active) VALUES (85, 50.99, 'stable', 27.48, 66);
INSERT INTO stream_events (count, weight, label, ratio, active) VALUES (1, 60.28, 'standard', 45.67, 1);
