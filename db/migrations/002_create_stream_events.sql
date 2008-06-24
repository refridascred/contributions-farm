-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, count, owner) VALUES ('green', 97, 'open');
INSERT INTO stream_events (token, count, owner) VALUES ('edge', 79, 'blue');
INSERT INTO stream_events (token, count, owner) VALUES ('edge', 25, 'latest');
