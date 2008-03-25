-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (count, state) VALUES (50, 'eu-west');
INSERT INTO stream_events (count, state) VALUES (26, 'fallback');
INSERT INTO stream_events (count, state) VALUES (62, 'local');
