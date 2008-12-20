-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, level, weight) VALUES (87, 79, 12.44);
INSERT INTO stream_events (count, level, weight) VALUES (55, 16, 72.85);
INSERT INTO stream_events (count, level, weight) VALUES (54, 19, 81.64);
