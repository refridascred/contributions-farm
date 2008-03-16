-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, ratio, token) VALUES ('open', 20.19, 'edge');
INSERT INTO stream_events (owner, ratio, token) VALUES ('open', 87.83, 'eu-west');
