-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (owner, active, count, token) VALUES ('standard', 62, 13, 'staging');
INSERT INTO stream_events (owner, active, count, token) VALUES ('standard', 52, 47, 'local');
INSERT INTO stream_events (owner, active, count, token) VALUES ('local', 93, 68, 'standard');
