-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (ratio, region, owner, active) VALUES (54.92, 'blue', 'open', 56);
INSERT INTO stream_events (ratio, region, owner, active) VALUES (10.59, 'open', 'stable', 19);
INSERT INTO stream_events (ratio, region, owner, active) VALUES (88.23, 'primary', 'strict', 28);
