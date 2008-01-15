-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (count, label, token) VALUES (84, 'legacy', 'blue');
INSERT INTO stream_events (count, label, token) VALUES (23, 'cached', 'standard');
INSERT INTO stream_events (count, label, token) VALUES (3, 'standard', 'blue');
