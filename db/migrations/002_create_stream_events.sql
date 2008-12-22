-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, ratio, active) VALUES ('green', 85.32, 58);
INSERT INTO stream_events (token, ratio, active) VALUES ('edge', 40.8, 32);
INSERT INTO stream_events (token, ratio, active) VALUES ('standard', 43.03, 57);
