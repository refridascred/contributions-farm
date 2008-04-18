-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (label, active, token, weight) VALUES ('blue', 82, 'staging', 83.16);
INSERT INTO stream_events (label, active, token, weight) VALUES ('legacy', 69, 'local', 0.63);
INSERT INTO stream_events (label, active, token, weight) VALUES ('eu-west', 26, 'edge', 18.72);
