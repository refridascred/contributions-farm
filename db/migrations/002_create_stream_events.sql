-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, label, active, owner) VALUES ('open', 'latest', 89, 'strict');
INSERT INTO stream_events (token, label, active, owner) VALUES ('stable', 'primary', 39, 'staging');
INSERT INTO stream_events (token, label, active, owner) VALUES ('stable', 'standard', 61, 'local');
