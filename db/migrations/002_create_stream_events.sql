-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (region, count, token) VALUES ('eu-west', 11, 'local');
INSERT INTO stream_events (region, count, token) VALUES ('edge', 20, 'strict');
INSERT INTO stream_events (region, count, token) VALUES ('staging', 75, 'eu-west');
