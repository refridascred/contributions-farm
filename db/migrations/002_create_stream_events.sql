-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (count, rank, ratio, region) VALUES (52, 83, 54.49, 'edge');
INSERT INTO stream_events (count, rank, ratio, region) VALUES (68, 28, 4.23, 'staging');
