-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (active, token, level, count) VALUES (83, 'cached', 52, 45);
INSERT INTO stream_events (active, token, level, count) VALUES (74, 'local', 97, 22);
INSERT INTO stream_events (active, token, level, count) VALUES (91, 'standard', 13, 18);
