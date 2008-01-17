-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (weight, owner, label, count, region) VALUES (74.19, 'cached', 'edge', 33, 'stable');
INSERT INTO stream_events (weight, owner, label, count, region) VALUES (69.51, 'primary', 'green', 69, 'latest');
