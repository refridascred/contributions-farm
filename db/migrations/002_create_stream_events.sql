-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (label, weight, count, level) VALUES ('open', 76.76, 66, 30);
INSERT INTO stream_events (label, weight, count, level) VALUES ('blue', 92.78, 11, 8);
INSERT INTO stream_events (label, weight, count, level) VALUES ('edge', 85.46, 55, 21);
