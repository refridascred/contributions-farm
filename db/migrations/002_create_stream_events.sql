-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (label, owner, count) VALUES ('stable', 'open', 92);
INSERT INTO stream_events (label, owner, count) VALUES ('primary', 'edge', 20);
INSERT INTO stream_events (label, owner, count) VALUES ('green', 'primary', 35);
