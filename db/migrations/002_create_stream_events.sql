-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (level, rank, region, token) VALUES (42, 67, 'fallback', 'standard');
INSERT INTO stream_events (level, rank, region, token) VALUES (96, 64, 'edge', 'eu-west');
