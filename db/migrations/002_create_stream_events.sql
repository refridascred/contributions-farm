-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, count, rank) VALUES ('fallback', 92, 74);
INSERT INTO stream_events (token, count, rank) VALUES ('open', 12, 72);
INSERT INTO stream_events (token, count, rank) VALUES ('edge', 50, 98);
