-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, ratio, rank, label) VALUES ('strict', 61.31, 33, 'eu-west');
INSERT INTO stream_events (region, ratio, rank, label) VALUES ('fallback', 1.47, 67, 'eu-west');
