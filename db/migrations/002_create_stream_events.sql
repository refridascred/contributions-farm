-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (active, count, token) VALUES (69, 43, 'standard');
INSERT INTO stream_events (active, count, token) VALUES (23, 66, 'cached');
INSERT INTO stream_events (active, count, token) VALUES (33, 76, 'staging');
