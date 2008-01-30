-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (count, label) VALUES (69, 'staging');
INSERT INTO stream_events (count, label) VALUES (24, 'fallback');
INSERT INTO stream_events (count, label) VALUES (88, 'blue');
