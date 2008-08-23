-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (level, ratio, rank, region) VALUES (69, 25.86, 70, 'cached');
INSERT INTO stream_events (level, ratio, rank, region) VALUES (8, 28.58, 6, 'staging');
