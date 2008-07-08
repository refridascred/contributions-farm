-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (active, token, level) VALUES (9, 'standard', 89);
INSERT INTO stream_events (active, token, level) VALUES (92, 'open', 59);
