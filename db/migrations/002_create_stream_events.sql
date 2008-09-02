-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, owner, token, active) VALUES (88.8, 'legacy', 'open', 97);
INSERT INTO stream_events (weight, owner, token, active) VALUES (13.99, 'cached', 'blue', 45);
