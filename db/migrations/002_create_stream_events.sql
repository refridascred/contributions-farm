-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    ratio REAL,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (level, region, ratio, token, label) VALUES (73, 'staging', 56.05, 'stable', 'edge');
INSERT INTO stream_events (level, region, ratio, token, label) VALUES (89, 'strict', 89.13, 'local', 'standard');
INSERT INTO stream_events (level, region, ratio, token, label) VALUES (45, 'legacy', 81.09, 'edge', 'latest');
