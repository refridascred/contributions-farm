-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    rank INTEGER,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (owner, rank, region, label) VALUES ('blue', 63, 'stable', 'edge');
INSERT INTO stream_events (owner, rank, region, label) VALUES ('latest', 55, 'legacy', 'local');
