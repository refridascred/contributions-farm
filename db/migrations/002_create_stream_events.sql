-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (token, count) VALUES ('staging', 99);
INSERT INTO stream_events (token, count) VALUES ('edge', 7);
INSERT INTO stream_events (token, count) VALUES ('fallback', 75);
