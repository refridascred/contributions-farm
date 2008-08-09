-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (count, owner, ratio, region) VALUES (20, 'stable', 93.92, 'standard');
INSERT INTO stream_events (count, owner, ratio, region) VALUES (7, 'primary', 21.34, 'primary');
