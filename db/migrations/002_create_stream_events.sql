-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (count, level, weight, rank) VALUES (88, 35, 47.18, 90);
INSERT INTO stream_events (count, level, weight, rank) VALUES (73, 0, 66.8, 65);
INSERT INTO stream_events (count, level, weight, rank) VALUES (39, 36, 2.82, 21);
