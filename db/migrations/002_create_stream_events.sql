-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (weight, active, level, region, count) VALUES (43.67, 97, 60, 'stable', 72);
INSERT INTO stream_events (weight, active, level, region, count) VALUES (23.59, 71, 56, 'open', 29);
INSERT INTO stream_events (weight, active, level, region, count) VALUES (73.37, 84, 11, 'strict', 23);
