-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (owner, count, token) VALUES ('strict', 74, 'latest');
INSERT INTO stream_events (owner, count, token) VALUES ('green', 71, 'local');
INSERT INTO stream_events (owner, count, token) VALUES ('edge', 1, 'staging');
