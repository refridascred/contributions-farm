-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (region, count, active, ratio, weight) VALUES ('green', 73, 48, 19.24, 88.07);
INSERT INTO stream_events (region, count, active, ratio, weight) VALUES ('edge', 11, 90, 86.01, 69.63);
INSERT INTO stream_events (region, count, active, ratio, weight) VALUES ('cached', 44, 43, 59.7, 26.44);
