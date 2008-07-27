-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (score, active, token) VALUES (61.3, 46, 'primary');
INSERT INTO stream_events (score, active, token) VALUES (37.43, 18, 'cached');
INSERT INTO stream_events (score, active, token) VALUES (72.48, 80, 'stable');
