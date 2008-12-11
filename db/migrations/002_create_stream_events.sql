-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (score, region, label, ratio) VALUES (24.44, 'stable', 'edge', 49.63);
INSERT INTO stream_events (score, region, label, ratio) VALUES (79.71, 'primary', 'stable', 93.58);
