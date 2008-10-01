-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (count, region, level, token) VALUES (59, 'standard', 67, 'primary');
INSERT INTO stream_events (count, region, level, token) VALUES (84, 'fallback', 77, 'latest');
INSERT INTO stream_events (count, region, level, token) VALUES (53, 'green', 30, 'green');
