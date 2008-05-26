-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, label, rank, score) VALUES (43.82, 'primary', 31, 29.76);
INSERT INTO stream_events (ratio, label, rank, score) VALUES (69.8, 'edge', 1, 48.85);
INSERT INTO stream_events (ratio, label, rank, score) VALUES (89.83, 'primary', 83, 98.8);
