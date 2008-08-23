-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (level, label, score) VALUES (5, 'standard', 85.46);
INSERT INTO stream_events (level, label, score) VALUES (35, 'strict', 61.86);
