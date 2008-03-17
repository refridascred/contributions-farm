-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    weight REAL,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (label, ratio, weight, rank, region) VALUES ('green', 28.61, 11.13, 90, 'fallback');
INSERT INTO stream_events (label, ratio, weight, rank, region) VALUES ('fallback', 84.78, 2.47, 21, 'cached');
