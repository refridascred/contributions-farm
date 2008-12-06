-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    rank INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (ratio, rank, region, state) VALUES (76.74, 81, 'fallback', 'green');
INSERT INTO stream_events (ratio, rank, region, state) VALUES (59.26, 61, 'eu-west', 'legacy');
