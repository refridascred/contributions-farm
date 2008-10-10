-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (count, owner) VALUES (97, 'fallback');
INSERT INTO stream_events (count, owner) VALUES (64, 'primary');
INSERT INTO stream_events (count, owner) VALUES (64, 'open');
