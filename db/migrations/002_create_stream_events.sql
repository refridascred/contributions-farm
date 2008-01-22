-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (count, active, level, weight) VALUES (70, 5, 76, 66.85);
INSERT INTO stream_events (count, active, level, weight) VALUES (65, 14, 86, 20.05);
INSERT INTO stream_events (count, active, level, weight) VALUES (24, 44, 62, 18.15);
