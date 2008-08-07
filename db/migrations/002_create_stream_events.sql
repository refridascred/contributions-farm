-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, ratio, label, count) VALUES (8.97, 14.76, 'standard', 42);
INSERT INTO stream_events (weight, ratio, label, count) VALUES (77.68, 79.41, 'edge', 50);
INSERT INTO stream_events (weight, ratio, label, count) VALUES (67.62, 91.33, 'local', 81);
