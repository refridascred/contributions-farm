-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (rank, region, label, weight) VALUES (5, 'stable', 'primary', 60.12);
INSERT INTO stream_events (rank, region, label, weight) VALUES (83, 'edge', 'legacy', 56.75);
