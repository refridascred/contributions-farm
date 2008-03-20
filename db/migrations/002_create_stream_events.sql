-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, ratio, weight) VALUES (67, 67.15, 52.04);
INSERT INTO stream_events (level, ratio, weight) VALUES (89, 10.0, 74.51);
INSERT INTO stream_events (level, ratio, weight) VALUES (42, 57.11, 50.38);
