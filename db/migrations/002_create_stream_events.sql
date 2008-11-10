-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, score, region, token, level) VALUES (57.89, 43.91, 'eu-west', 'local', 51);
INSERT INTO stream_events (ratio, score, region, token, level) VALUES (65.85, 38.62, 'fallback', 'eu-west', 3);
INSERT INTO stream_events (ratio, score, region, token, level) VALUES (86.46, 72.93, 'strict', 'local', 68);
