-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (owner, token, active, score) VALUES ('legacy', 'eu-west', 59, 24.42);
INSERT INTO stream_events (owner, token, active, score) VALUES ('primary', 'standard', 52, 50.91);
