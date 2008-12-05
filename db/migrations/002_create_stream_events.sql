-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (score, token, level, count) VALUES (75.69, 'fallback', 61, 22);
INSERT INTO stream_events (score, token, level, count) VALUES (4.51, 'open', 39, 28);
INSERT INTO stream_events (score, token, level, count) VALUES (6.57, 'fallback', 20, 41);
