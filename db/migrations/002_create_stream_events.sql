-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (count, ratio, weight, level) VALUES (38, 2.7, 85.79, 26);
INSERT INTO stream_events (count, ratio, weight, level) VALUES (96, 67.97, 81.71, 81);
INSERT INTO stream_events (count, ratio, weight, level) VALUES (46, 22.4, 87.78, 98);
