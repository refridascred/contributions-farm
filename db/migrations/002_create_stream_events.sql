-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, weight, ratio, rank) VALUES (29, 45.57, 88.92, 96);
INSERT INTO stream_events (level, weight, ratio, rank) VALUES (62, 63.04, 67.05, 99);
