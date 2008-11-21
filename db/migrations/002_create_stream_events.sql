-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (ratio, token, region, active, level) VALUES (23.92, 'fallback', 'local', 75, 3);
INSERT INTO stream_events (ratio, token, region, active, level) VALUES (81.56, 'latest', 'local', 96, 32);
