-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (active, token, rank, region) VALUES (17, 'fallback', 29, 'legacy');
INSERT INTO stream_events (active, token, rank, region) VALUES (30, 'stable', 65, 'eu-west');
