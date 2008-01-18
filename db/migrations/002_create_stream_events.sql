-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (token, ratio, level, active, count) VALUES ('fallback', 69.92, 61, 25, 97);
INSERT INTO stream_events (token, ratio, level, active, count) VALUES ('cached', 33.3, 47, 13, 79);
