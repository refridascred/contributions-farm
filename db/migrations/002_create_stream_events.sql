-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    ratio REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (region, ratio, token, score) VALUES ('local', 94.39, 'cached', 33.78);
INSERT INTO stream_events (region, ratio, token, score) VALUES ('green', 72.19, 'green', 95.77);
INSERT INTO stream_events (region, ratio, token, score) VALUES ('fallback', 79.97, 'cached', 9.96);
