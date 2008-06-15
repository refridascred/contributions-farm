-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (active, owner, rank, region) VALUES (60, 'legacy', 25, 'local');
INSERT INTO stream_events (active, owner, rank, region) VALUES (85, 'fallback', 85, 'local');
