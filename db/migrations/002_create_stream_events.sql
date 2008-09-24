-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    region TEXT,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, region, token, count) VALUES ('staging', 'edge', 'staging', 50);
INSERT INTO stream_events (owner, region, token, count) VALUES ('primary', 'edge', 'green', 41);
INSERT INTO stream_events (owner, region, token, count) VALUES ('legacy', 'primary', 'edge', 45);
