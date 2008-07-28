-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (ratio, active, level, rank) VALUES (42.71, 13, 3, 3);
INSERT INTO stream_events (ratio, active, level, rank) VALUES (66.96, 21, 79, 58);
INSERT INTO stream_events (ratio, active, level, rank) VALUES (28.09, 10, 78, 76);
