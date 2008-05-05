-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (label, token, region, active) VALUES ('legacy', 'cached', 'green', 52);
INSERT INTO stream_events (label, token, region, active) VALUES ('eu-west', 'stable', 'eu-west', 5);
