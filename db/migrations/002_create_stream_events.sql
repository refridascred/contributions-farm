-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (region, level, owner, active) VALUES ('fallback', 48, 'staging', 64);
INSERT INTO stream_events (region, level, owner, active) VALUES ('standard', 11, 'fallback', 38);
