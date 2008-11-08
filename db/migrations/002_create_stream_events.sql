-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (ratio, level, weight, count) VALUES (11.97, 18, 63.86, 98);
INSERT INTO stream_events (ratio, level, weight, count) VALUES (81.95, 53, 18.93, 76);
