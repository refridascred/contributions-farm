-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (count, active, token) VALUES (39, 69, 'open');
INSERT INTO stream_events (count, active, token) VALUES (23, 21, 'green');
INSERT INTO stream_events (count, active, token) VALUES (69, 29, 'fallback');
