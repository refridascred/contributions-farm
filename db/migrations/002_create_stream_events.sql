-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    ratio REAL,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (weight, rank, ratio, region, owner) VALUES (92.37, 60, 63.32, 'cached', 'fallback');
INSERT INTO stream_events (weight, rank, ratio, region, owner) VALUES (71.8, 47, 5.88, 'stable', 'stable');
INSERT INTO stream_events (weight, rank, ratio, region, owner) VALUES (73.04, 84, 47.33, 'green', 'green');
