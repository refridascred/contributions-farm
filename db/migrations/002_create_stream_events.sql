-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (count, ratio, level) VALUES (96, 33.54, 56);
INSERT INTO stream_events (count, ratio, level) VALUES (34, 18.28, 6);
INSERT INTO stream_events (count, ratio, level) VALUES (39, 88.99, 56);
