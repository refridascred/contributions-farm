-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (score, ratio, region) VALUES (84.42, 73.38, 'fallback');
INSERT INTO stream_events (score, ratio, region) VALUES (21.57, 2.09, 'latest');
INSERT INTO stream_events (score, ratio, region) VALUES (2.27, 62.49, 'standard');
