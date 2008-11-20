-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (level, weight, count, rank) VALUES (40, 4.37, 39, 59);
INSERT INTO stream_events (level, weight, count, rank) VALUES (94, 43.12, 24, 83);
