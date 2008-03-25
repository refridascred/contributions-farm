-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (label, token, active) VALUES ('strict', 'blue', 0);
INSERT INTO stream_events (label, token, active) VALUES ('blue', 'standard', 85);
INSERT INTO stream_events (label, token, active) VALUES ('open', 'edge', 65);
