-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (owner, region, count, active) VALUES ('eu-west', 'strict', 54, 77);
INSERT INTO stream_events (owner, region, count, active) VALUES ('standard', 'staging', 27, 8);
INSERT INTO stream_events (owner, region, count, active) VALUES ('blue', 'staging', 66, 93);
