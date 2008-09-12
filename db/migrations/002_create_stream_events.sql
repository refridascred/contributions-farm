-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (weight, score, owner, active) VALUES (63.48, 24.25, 'eu-west', 46);
INSERT INTO stream_events (weight, score, owner, active) VALUES (83.49, 56.78, 'strict', 90);
