-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (owner, ratio, token) VALUES ('primary', 39.4, 'primary');
INSERT INTO stream_events (owner, ratio, token) VALUES ('standard', 4.42, 'eu-west');
