-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (label, ratio, score, token) VALUES ('standard', 5.69, 57.27, 'local');
INSERT INTO stream_events (label, ratio, score, token) VALUES ('green', 23.5, 42.26, 'fallback');
