-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (token, label, score, active) VALUES ('strict', 'stable', 98.62, 65);
INSERT INTO stream_events (token, label, score, active) VALUES ('edge', 'edge', 64.52, 65);
