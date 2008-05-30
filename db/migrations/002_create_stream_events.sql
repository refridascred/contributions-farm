-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, active) VALUES ('primary', 45);
INSERT INTO stream_events (token, active) VALUES ('fallback', 17);
INSERT INTO stream_events (token, active) VALUES ('eu-west', 84);
