-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    created_at TIMESTAMP,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, region, label, ratio) VALUES (30, 'legacy', 'strict', 74.49);
INSERT INTO stream_events (level, region, label, ratio) VALUES (98, 'primary', 'stable', 6.83);
INSERT INTO stream_events (level, region, label, ratio) VALUES (37, 'edge', 'strict', 56.72);
