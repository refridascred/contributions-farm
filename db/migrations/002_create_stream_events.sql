-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (ratio, region, rank, label) VALUES (92.16, 'primary', 38, 'stable');
INSERT INTO stream_events (ratio, region, rank, label) VALUES (40.91, 'cached', 85, 'latest');
