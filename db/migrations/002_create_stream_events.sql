-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (score, active, weight, token) VALUES (65.7, 98, 77.2, 'green');
INSERT INTO stream_events (score, active, weight, token) VALUES (14.45, 94, 40.24, 'strict');
INSERT INTO stream_events (score, active, weight, token) VALUES (46.2, 38, 23.8, 'open');
