-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (weight, ratio, count, level, rank) VALUES (71.07, 51.27, 45, 66, 77);
INSERT INTO stream_events (weight, ratio, count, level, rank) VALUES (53.58, 77.49, 62, 6, 9);
INSERT INTO stream_events (weight, ratio, count, level, rank) VALUES (80.69, 28.57, 87, 83, 66);
