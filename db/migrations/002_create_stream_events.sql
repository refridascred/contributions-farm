-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (weight, count, level) VALUES (54.89, 30, 52);
INSERT INTO stream_events (weight, count, level) VALUES (27.89, 65, 25);
INSERT INTO stream_events (weight, count, level) VALUES (39.15, 51, 44);
