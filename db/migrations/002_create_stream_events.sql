-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (count, label, weight, ratio, score) VALUES (20, 'blue', 85.54, 34.52, 96.03);
INSERT INTO stream_events (count, label, weight, ratio, score) VALUES (11, 'edge', 68.47, 94.43, 77.13);
