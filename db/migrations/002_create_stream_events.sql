-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (owner, ratio, active, token) VALUES ('standard', 98.61, 78, 'local');
INSERT INTO stream_events (owner, ratio, active, token) VALUES ('eu-west', 81.33, 41, 'standard');
