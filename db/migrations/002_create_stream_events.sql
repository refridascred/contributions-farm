-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, owner, token) VALUES (8, 'fallback', 'eu-west');
INSERT INTO stream_events (count, owner, token) VALUES (58, 'edge', 'legacy');
INSERT INTO stream_events (count, owner, token) VALUES (1, 'strict', 'eu-west');
