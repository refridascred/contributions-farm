-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, label, active, token) VALUES (55, 'eu-west', 20, 'blue');
INSERT INTO stream_events (count, label, active, token) VALUES (60, 'fallback', 44, 'open');
INSERT INTO stream_events (count, label, active, token) VALUES (65, 'eu-west', 54, 'open');
