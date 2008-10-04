-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, level, count) VALUES (0.24, 28, 2);
INSERT INTO stream_events (score, level, count) VALUES (31.95, 65, 41);
INSERT INTO stream_events (score, level, count) VALUES (65.54, 89, 11);
