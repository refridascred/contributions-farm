-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, rank, region) VALUES (0.96, 45, 'edge');
INSERT INTO stream_events (ratio, rank, region) VALUES (42.8, 22, 'latest');
INSERT INTO stream_events (ratio, rank, region) VALUES (87.15, 68, 'local');
