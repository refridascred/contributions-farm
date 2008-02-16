-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (rank, region, ratio, active) VALUES (70, 'stable', 4.73, 68);
INSERT INTO stream_events (rank, region, ratio, active) VALUES (78, 'edge', 82.2, 62);
INSERT INTO stream_events (rank, region, ratio, active) VALUES (94, 'edge', 5.07, 42);
