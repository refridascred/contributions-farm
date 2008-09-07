-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (active, token, ratio, score) VALUES (48, 'local', 54.98, 26.21);
INSERT INTO stream_events (active, token, ratio, score) VALUES (91, 'cached', 66.72, 21.3);
