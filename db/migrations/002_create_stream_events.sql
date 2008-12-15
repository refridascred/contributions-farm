-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (level, region, label, owner) VALUES (44, 'stable', 'open', 'strict');
INSERT INTO stream_events (level, region, label, owner) VALUES (46, 'latest', 'primary', 'staging');
