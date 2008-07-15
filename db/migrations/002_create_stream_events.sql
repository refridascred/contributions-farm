-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (ratio, active, token, owner) VALUES (57.11, 34, 'open', 'green');
INSERT INTO stream_events (ratio, active, token, owner) VALUES (29.8, 91, 'stable', 'standard');
