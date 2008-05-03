-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (count, label, active) VALUES (85, 'local', 73);
INSERT INTO stream_events (count, label, active) VALUES (29, 'staging', 15);
INSERT INTO stream_events (count, label, active) VALUES (80, 'latest', 78);
