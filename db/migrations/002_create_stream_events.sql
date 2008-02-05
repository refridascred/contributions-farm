-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (active, token, level) VALUES (91, 'green', 46);
INSERT INTO stream_events (active, token, level) VALUES (58, 'legacy', 70);
INSERT INTO stream_events (active, token, level) VALUES (4, 'primary', 11);
