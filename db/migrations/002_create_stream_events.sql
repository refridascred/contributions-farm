-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (label, active, token, count) VALUES ('open', 63, 'fallback', 91);
INSERT INTO stream_events (label, active, token, count) VALUES ('stable', 28, 'open', 55);
INSERT INTO stream_events (label, active, token, count) VALUES ('legacy', 85, 'blue', 33);
