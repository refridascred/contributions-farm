-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (label, count, active, token) VALUES ('cached', 69, 38, 'eu-west');
INSERT INTO stream_events (label, count, active, token) VALUES ('staging', 43, 40, 'open');
INSERT INTO stream_events (label, count, active, token) VALUES ('eu-west', 36, 32, 'eu-west');
