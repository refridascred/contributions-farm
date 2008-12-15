-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, owner, count, region) VALUES (92.83, 'legacy', 17, 'green');
INSERT INTO stream_events (ratio, owner, count, region) VALUES (79.48, 'green', 56, 'fallback');
INSERT INTO stream_events (ratio, owner, count, region) VALUES (45.41, 'cached', 97, 'latest');
