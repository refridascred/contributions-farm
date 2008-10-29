-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (count, active, label) VALUES (62, 84, 'legacy');
INSERT INTO stream_events (count, active, label) VALUES (99, 18, 'stable');
INSERT INTO stream_events (count, active, label) VALUES (21, 42, 'eu-west');
