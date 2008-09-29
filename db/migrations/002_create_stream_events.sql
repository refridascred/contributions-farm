-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (score, label, count, ratio, token) VALUES (36.7, 'primary', 83, 85.74, 'strict');
INSERT INTO stream_events (score, label, count, ratio, token) VALUES (26.79, 'local', 19, 31.91, 'blue');
