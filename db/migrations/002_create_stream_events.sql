-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, region, level) VALUES (54.44, 'edge', 4);
INSERT INTO stream_events (ratio, region, level) VALUES (28.28, 'strict', 92);
INSERT INTO stream_events (ratio, region, level) VALUES (50.6, 'primary', 22);
