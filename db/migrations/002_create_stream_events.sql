-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (count, level, ratio, token, score) VALUES (25, 17, 13.95, 'open', 69.85);
INSERT INTO stream_events (count, level, ratio, token, score) VALUES (68, 60, 77.13, 'cached', 91.75);
