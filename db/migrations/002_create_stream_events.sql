-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (ratio, token, count, level) VALUES (69.79, 'blue', 39, 28);
INSERT INTO stream_events (ratio, token, count, level) VALUES (17.01, 'fallback', 78, 62);
