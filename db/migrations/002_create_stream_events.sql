-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, token, label, ratio) VALUES (39.71, 'edge', 'strict', 15.69);
INSERT INTO stream_events (score, token, label, ratio) VALUES (81.78, 'strict', 'strict', 1.51);
