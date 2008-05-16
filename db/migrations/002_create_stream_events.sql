-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (weight, count, label, region, owner) VALUES (24.59, 77, 'local', 'blue', 'local');
INSERT INTO stream_events (weight, count, label, region, owner) VALUES (60.58, 77, 'staging', 'green', 'eu-west');
