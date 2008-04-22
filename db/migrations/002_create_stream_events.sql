-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, score, owner, label) VALUES ('staging', 60.84, 'legacy', 'strict');
INSERT INTO stream_events (region, score, owner, label) VALUES ('stable', 86.12, 'edge', 'open');
