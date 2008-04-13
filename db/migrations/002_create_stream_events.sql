-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (label, ratio, token) VALUES ('standard', 83.25, 'eu-west');
INSERT INTO stream_events (label, ratio, token) VALUES ('local', 27.92, 'standard');
INSERT INTO stream_events (label, ratio, token) VALUES ('latest', 65.39, 'open');
