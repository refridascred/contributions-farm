-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (count, token, weight) VALUES (75, 'strict', 54.58);
INSERT INTO stream_events (count, token, weight) VALUES (44, 'open', 56.82);
INSERT INTO stream_events (count, token, weight) VALUES (98, 'green', 85.84);
