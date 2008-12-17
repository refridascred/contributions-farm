-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (active, rank, region, token) VALUES (80, 78, 'local', 'staging');
INSERT INTO stream_events (active, rank, region, token) VALUES (99, 36, 'strict', 'eu-west');
INSERT INTO stream_events (active, rank, region, token) VALUES (57, 89, 'cached', 'open');
