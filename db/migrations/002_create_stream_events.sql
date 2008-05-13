-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    rank INTEGER,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (score, rank, label, token) VALUES (12.69, 68, 'fallback', 'legacy');
INSERT INTO stream_events (score, rank, label, token) VALUES (13.73, 96, 'green', 'latest');
