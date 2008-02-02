-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (rank, ratio, region, token) VALUES (13, 42.84, 'cached', 'latest');
INSERT INTO stream_events (rank, ratio, region, token) VALUES (88, 75.39, 'stable', 'edge');
