-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (region, level, token) VALUES ('legacy', 26, 'latest');
INSERT INTO stream_events (region, level, token) VALUES ('blue', 23, 'open');
