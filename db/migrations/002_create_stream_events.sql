-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (rank, active, region, ratio, score) VALUES (84, 70, 'stable', 11.98, 67.22);
INSERT INTO stream_events (rank, active, region, ratio, score) VALUES (92, 15, 'edge', 78.68, 78.02);
