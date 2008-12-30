-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    created_at TIMESTAMP,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, level, ratio, count) VALUES (92.27, 65, 23.02, 33);
INSERT INTO stream_events (weight, level, ratio, count) VALUES (3.25, 37, 65.96, 97);
INSERT INTO stream_events (weight, level, ratio, count) VALUES (3.89, 48, 52.07, 32);
