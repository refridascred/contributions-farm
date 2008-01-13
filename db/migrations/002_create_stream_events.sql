-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (label, count, token) VALUES ('green', 18, 'edge');
INSERT INTO stream_events (label, count, token) VALUES ('open', 59, 'standard');
INSERT INTO stream_events (label, count, token) VALUES ('latest', 53, 'cached');
