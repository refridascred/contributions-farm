-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    level INTEGER,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (count, weight, level, rank, token) VALUES (58, 39.3, 7, 77, 'eu-west');
INSERT INTO stream_events (count, weight, level, rank, token) VALUES (7, 22.91, 48, 36, 'strict');
