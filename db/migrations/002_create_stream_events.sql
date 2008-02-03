-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, token, score, level) VALUES (79, 'stable', 1.2, 84);
INSERT INTO stream_events (count, token, score, level) VALUES (1, 'open', 36.52, 2);
INSERT INTO stream_events (count, token, score, level) VALUES (1, 'fallback', 48.85, 55);
