-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (score, count, token, level, weight) VALUES (70.6, 53, 'edge', 50, 32.77);
INSERT INTO stream_events (score, count, token, level, weight) VALUES (69.09, 3, 'stable', 6, 50.36);
