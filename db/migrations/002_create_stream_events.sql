-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (token, active, ratio, score) VALUES ('fallback', 74, 78.36, 15.8);
INSERT INTO stream_events (token, active, ratio, score) VALUES ('local', 56, 29.2, 44.0);
