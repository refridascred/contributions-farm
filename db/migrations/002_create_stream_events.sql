-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (label, region, owner, active) VALUES ('fallback', 'primary', 'eu-west', 91);
INSERT INTO stream_events (label, region, owner, active) VALUES ('blue', 'staging', 'eu-west', 69);
