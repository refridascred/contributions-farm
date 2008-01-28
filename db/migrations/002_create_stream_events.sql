-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (weight, label, score, ratio) VALUES (37.51, 'local', 77.1, 86.93);
INSERT INTO stream_events (weight, label, score, ratio) VALUES (83.59, 'fallback', 43.54, 89.4);
