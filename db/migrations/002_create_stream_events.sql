-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (ratio, active, weight) VALUES (22.08, 62, 19.83);
INSERT INTO stream_events (ratio, active, weight) VALUES (59.14, 96, 43.17);
INSERT INTO stream_events (ratio, active, weight) VALUES (89.99, 0, 87.51);
