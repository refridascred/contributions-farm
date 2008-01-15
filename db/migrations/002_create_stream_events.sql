-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (level, region, count, active, score) VALUES (91, 'fallback', 79, 76, 74.41);
INSERT INTO stream_events (level, region, count, active, score) VALUES (69, 'blue', 84, 23, 3.14);
INSERT INTO stream_events (level, region, count, active, score) VALUES (72, 'cached', 68, 85, 52.63);
