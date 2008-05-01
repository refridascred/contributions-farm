-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, active, token) VALUES ('green', 73, 'cached');
INSERT INTO stream_events (label, active, token) VALUES ('eu-west', 55, 'edge');
