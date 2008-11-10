-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, count) VALUES ('local', 10);
INSERT INTO stream_events (token, count) VALUES ('staging', 48);
INSERT INTO stream_events (token, count) VALUES ('cached', 47);
