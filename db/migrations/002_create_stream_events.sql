-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    level INTEGER,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (rank, region, level, ratio, active) VALUES (51, 'fallback', 54, 48.87, 71);
INSERT INTO stream_events (rank, region, level, ratio, active) VALUES (78, 'stable', 52, 90.4, 1);
