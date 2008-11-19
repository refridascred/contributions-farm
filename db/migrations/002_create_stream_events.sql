-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, active, token) VALUES (88.76, 85, 'local');
INSERT INTO stream_events (weight, active, token) VALUES (10.06, 7, 'open');
INSERT INTO stream_events (weight, active, token) VALUES (60.76, 82, 'eu-west');
