-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    ratio REAL,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (active, weight, ratio, level, rank) VALUES (40, 38.74, 27.21, 84, 24);
INSERT INTO stream_events (active, weight, ratio, level, rank) VALUES (49, 73.87, 30.06, 91, 93);
