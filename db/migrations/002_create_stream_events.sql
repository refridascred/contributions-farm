-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (token, ratio, level, count) VALUES ('latest', 50.78, 6, 31);
INSERT INTO stream_events (token, ratio, level, count) VALUES ('fallback', 16.01, 54, 40);
