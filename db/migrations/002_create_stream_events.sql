-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (token, ratio, level) VALUES ('blue', 34.79, 73);
INSERT INTO stream_events (token, ratio, level) VALUES ('strict', 44.59, 55);
INSERT INTO stream_events (token, ratio, level) VALUES ('fallback', 85.16, 48);
