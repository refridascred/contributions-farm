-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    region TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, label, region, owner, count) VALUES (31, 'blue', 'latest', 'primary', 46);
INSERT INTO stream_events (active, label, region, owner, count) VALUES (3, 'standard', 'latest', 'edge', 52);
