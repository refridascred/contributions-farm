-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (token, count, weight, label, level) VALUES ('blue', 9, 90.32, 'blue', 64);
INSERT INTO stream_events (token, count, weight, label, level) VALUES ('strict', 8, 95.83, 'edge', 99);
INSERT INTO stream_events (token, count, weight, label, level) VALUES ('stable', 21, 35.63, 'latest', 64);
