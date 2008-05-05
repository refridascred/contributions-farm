-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (ratio, count, active, token, label) VALUES (53.36, 75, 63, 'latest', 'local');
INSERT INTO stream_events (ratio, count, active, token, label) VALUES (21.62, 97, 36, 'legacy', 'strict');
INSERT INTO stream_events (ratio, count, active, token, label) VALUES (21.76, 4, 89, 'legacy', 'strict');
