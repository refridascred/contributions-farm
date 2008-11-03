-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    ratio REAL,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (rank, level, ratio, region, token) VALUES (35, 37, 4.53, 'legacy', 'stable');
INSERT INTO stream_events (rank, level, ratio, region, token) VALUES (89, 93, 73.39, 'stable', 'strict');
