-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (count, weight, level) VALUES (0, 15.66, 90);
INSERT INTO stream_events (count, weight, level) VALUES (57, 3.06, 52);
INSERT INTO stream_events (count, weight, level) VALUES (34, 6.05, 13);
