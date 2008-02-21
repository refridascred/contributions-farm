-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (region, count, token, level) VALUES ('latest', 68, 'edge', 68);
INSERT INTO stream_events (region, count, token, level) VALUES ('fallback', 9, 'legacy', 64);
