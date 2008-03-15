-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (score, region, label, ratio) VALUES (20.27, 'latest', 'blue', 92.48);
INSERT INTO stream_events (score, region, label, ratio) VALUES (95.9, 'local', 'standard', 76.25);
