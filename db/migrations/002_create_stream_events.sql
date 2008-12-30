-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (ratio, token, active, score) VALUES (62.92, 'cached', 25, 46.52);
INSERT INTO stream_events (ratio, token, active, score) VALUES (93.41, 'local', 59, 12.82);
