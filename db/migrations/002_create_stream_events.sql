-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, region, score) VALUES (33.38, 'blue', 53.82);
INSERT INTO stream_events (ratio, region, score) VALUES (38.08, 'edge', 9.95);
