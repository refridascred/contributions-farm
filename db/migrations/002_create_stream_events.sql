-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, ratio, rank, score, level) VALUES ('edge', 89.9, 34, 98.02, 10);
INSERT INTO stream_events (label, ratio, rank, score, level) VALUES ('strict', 36.95, 56, 8.47, 63);
INSERT INTO stream_events (label, ratio, rank, score, level) VALUES ('standard', 94.12, 72, 50.52, 17);
