-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (label, active, token) VALUES ('eu-west', 60, 'latest');
INSERT INTO stream_events (label, active, token) VALUES ('primary', 99, 'local');
INSERT INTO stream_events (label, active, token) VALUES ('green', 42, 'open');
