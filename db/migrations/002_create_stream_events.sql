-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (active, weight, ratio, count) VALUES (35, 95.41, 23.67, 83);
INSERT INTO stream_events (active, weight, ratio, count) VALUES (89, 13.22, 64.52, 16);
INSERT INTO stream_events (active, weight, ratio, count) VALUES (74, 56.59, 15.93, 70);
