-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, label) VALUES (46, 'cached');
INSERT INTO stream_events (active, label) VALUES (94, 'strict');
INSERT INTO stream_events (active, label) VALUES (54, 'blue');
