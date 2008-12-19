-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (weight, count, level) VALUES (23.87, 32, 73);
INSERT INTO stream_events (weight, count, level) VALUES (14.96, 95, 74);
