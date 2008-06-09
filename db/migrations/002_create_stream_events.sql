-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (weight, ratio, count, level) VALUES (63.71, 42.22, 88, 87);
INSERT INTO stream_events (weight, ratio, count, level) VALUES (15.16, 37.14, 18, 0);
INSERT INTO stream_events (weight, ratio, count, level) VALUES (40.45, 96.56, 55, 96);
