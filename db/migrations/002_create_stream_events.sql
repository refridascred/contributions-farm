-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (count, token, weight) VALUES (88, 'strict', 64.64);
INSERT INTO stream_events (count, token, weight) VALUES (4, 'fallback', 59.7);
