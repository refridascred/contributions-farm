-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, count, region, token) VALUES ('primary', 27, 'eu-west', 'fallback');
INSERT INTO stream_events (owner, count, region, token) VALUES ('latest', 57, 'local', 'green');
INSERT INTO stream_events (owner, count, region, token) VALUES ('stable', 68, 'local', 'eu-west');
