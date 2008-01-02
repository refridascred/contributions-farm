-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (count, active, state, label) VALUES (32, 89, 'blue', 'primary');
INSERT INTO stream_events (count, active, state, label) VALUES (46, 69, 'local', 'edge');
INSERT INTO stream_events (count, active, state, label) VALUES (11, 81, 'staging', 'stable');
