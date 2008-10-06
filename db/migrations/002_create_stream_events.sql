-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (level, count, region, active) VALUES (33, 73, 'blue', 14);
INSERT INTO stream_events (level, count, region, active) VALUES (16, 52, 'stable', 73);
INSERT INTO stream_events (level, count, region, active) VALUES (71, 23, 'strict', 11);
