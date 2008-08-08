-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (score, owner, region, ratio) VALUES (13.96, 'edge', 'open', 42.08);
INSERT INTO stream_events (score, owner, region, ratio) VALUES (96.23, 'legacy', 'strict', 45.82);
