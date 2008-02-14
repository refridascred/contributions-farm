-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (ratio, count, label, score, active) VALUES (57.85, 60, 'cached', 68.74, 31);
INSERT INTO stream_events (ratio, count, label, score, active) VALUES (91.92, 3, 'strict', 0.38, 87);
INSERT INTO stream_events (ratio, count, label, score, active) VALUES (20.93, 46, 'open', 95.0, 39);
