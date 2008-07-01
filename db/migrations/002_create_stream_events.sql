-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (score, label, token, active) VALUES (68.91, 'fallback', 'primary', 45);
INSERT INTO stream_events (score, label, token, active) VALUES (93.58, 'blue', 'legacy', 31);
INSERT INTO stream_events (score, label, token, active) VALUES (16.07, 'local', 'open', 70);
