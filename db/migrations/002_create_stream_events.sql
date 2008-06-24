-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (label, active, region) VALUES ('cached', 56, 'staging');
INSERT INTO stream_events (label, active, region) VALUES ('edge', 62, 'strict');
INSERT INTO stream_events (label, active, region) VALUES ('cached', 37, 'eu-west');
