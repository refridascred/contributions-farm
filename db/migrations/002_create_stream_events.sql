-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (active, token, count) VALUES (55, 'strict', 66);
INSERT INTO stream_events (active, token, count) VALUES (78, 'edge', 52);
INSERT INTO stream_events (active, token, count) VALUES (79, 'latest', 18);
