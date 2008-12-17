-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, rank, count) VALUES ('stable', 4, 55);
INSERT INTO stream_events (token, rank, count) VALUES ('fallback', 26, 86);
INSERT INTO stream_events (token, rank, count) VALUES ('green', 11, 9);
