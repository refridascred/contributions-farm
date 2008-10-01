-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (region, token, active, rank) VALUES ('open', 'fallback', 32, 4);
INSERT INTO stream_events (region, token, active, rank) VALUES ('fallback', 'eu-west', 37, 51);
INSERT INTO stream_events (region, token, active, rank) VALUES ('open', 'staging', 26, 15);
