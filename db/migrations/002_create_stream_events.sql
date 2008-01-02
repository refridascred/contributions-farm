-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (owner, level, active, region) VALUES ('edge', 27, 66, 'legacy');
INSERT INTO stream_events (owner, level, active, region) VALUES ('strict', 18, 12, 'strict');
