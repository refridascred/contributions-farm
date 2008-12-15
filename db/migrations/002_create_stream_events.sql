-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    rank INTEGER,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (score, label, rank, ratio, token) VALUES (93.89, 'primary', 92, 58.13, 'cached');
INSERT INTO stream_events (score, label, rank, ratio, token) VALUES (69.08, 'local', 92, 89.14, 'strict');
INSERT INTO stream_events (score, label, rank, ratio, token) VALUES (85.84, 'standard', 56, 85.65, 'blue');
