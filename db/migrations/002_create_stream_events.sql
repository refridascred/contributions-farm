-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (active, weight, count, level, owner) VALUES (81, 41.89, 34, 75, 'stable');
INSERT INTO stream_events (active, weight, count, level, owner) VALUES (1, 51.17, 19, 33, 'legacy');
