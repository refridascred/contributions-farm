-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (count, active, token) VALUES (59, 39, 'primary');
INSERT INTO stream_events (count, active, token) VALUES (47, 49, 'strict');
INSERT INTO stream_events (count, active, token) VALUES (83, 87, 'legacy');
