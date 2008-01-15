-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    region TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (label, region, level, weight) VALUES ('strict', 'strict', 6, 36.49);
INSERT INTO stream_events (label, region, level, weight) VALUES ('legacy', 'local', 89, 49.63);
