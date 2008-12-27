-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (region, active, token) VALUES ('local', 86, 'local');
INSERT INTO stream_events (region, active, token) VALUES ('legacy', 63, 'green');
