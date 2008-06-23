-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    label TEXT,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (region, token, label, owner) VALUES ('eu-west', 'staging', 'eu-west', 'legacy');
INSERT INTO stream_events (region, token, label, owner) VALUES ('staging', 'blue', 'edge', 'green');
