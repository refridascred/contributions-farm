-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (score, label, weight, active) VALUES (31.58, 'stable', 38.25, 97);
INSERT INTO stream_events (score, label, weight, active) VALUES (90.92, 'strict', 92.49, 95);
INSERT INTO stream_events (score, label, weight, active) VALUES (15.05, 'primary', 52.07, 51);
