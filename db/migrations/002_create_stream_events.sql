-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, region, rank) VALUES ('green', 'edge', 65);
INSERT INTO stream_events (token, region, rank) VALUES ('legacy', 'fallback', 8);
