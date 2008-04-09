-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    owner TEXT NOT NULL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (active, token, owner, weight, score) VALUES (79, 'blue', 'green', 49.47, 58.12);
INSERT INTO stream_events (active, token, owner, weight, score) VALUES (95, 'staging', 'green', 33.99, 15.95);
