-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (label, owner, count, region) VALUES ('primary', 'cached', 61, 'eu-west');
INSERT INTO stream_events (label, owner, count, region) VALUES ('standard', 'green', 37, 'cached');
