-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (token, active, owner, label) VALUES ('fallback', 57, 'latest', 'green');
INSERT INTO stream_events (token, active, owner, label) VALUES ('standard', 8, 'eu-west', 'stable');
INSERT INTO stream_events (token, active, owner, label) VALUES ('fallback', 9, 'eu-west', 'open');
