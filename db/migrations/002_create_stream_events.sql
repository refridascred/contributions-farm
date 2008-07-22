-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    region TEXT,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (active, region, label, owner) VALUES (64, 'primary', 'green', 'blue');
INSERT INTO stream_events (active, region, label, owner) VALUES (18, 'standard', 'eu-west', 'staging');
