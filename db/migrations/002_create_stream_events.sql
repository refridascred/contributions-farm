-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    region TEXT,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (level, weight, region, owner) VALUES (50, 96.23, 'legacy', 'legacy');
INSERT INTO stream_events (level, weight, region, owner) VALUES (83, 78.31, 'edge', 'edge');
