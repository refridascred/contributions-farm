-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (count, score, token, active) VALUES (53, 98.39, 'strict', 77);
INSERT INTO stream_events (count, score, token, active) VALUES (32, 57.95, 'fallback', 64);
INSERT INTO stream_events (count, score, token, active) VALUES (87, 78.33, 'primary', 42);
