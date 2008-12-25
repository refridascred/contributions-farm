-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (owner, active, token, label) VALUES ('strict', 74, 'staging', 'latest');
INSERT INTO stream_events (owner, active, token, label) VALUES ('green', 45, 'staging', 'primary');
INSERT INTO stream_events (owner, active, token, label) VALUES ('latest', 20, 'green', 'staging');
