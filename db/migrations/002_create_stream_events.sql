-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (rank, ratio, region) VALUES (5, 59.07, 'legacy');
INSERT INTO stream_events (rank, ratio, region) VALUES (23, 47.45, 'latest');
INSERT INTO stream_events (rank, ratio, region) VALUES (57, 26.64, 'fallback');
