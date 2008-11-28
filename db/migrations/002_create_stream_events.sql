-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (token, score, label, weight) VALUES ('stable', 0.58, 'fallback', 36.12);
INSERT INTO stream_events (token, score, label, weight) VALUES ('stable', 54.94, 'strict', 8.96);
INSERT INTO stream_events (token, score, label, weight) VALUES ('stable', 95.07, 'edge', 97.29);
