-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (region, count, weight, label) VALUES ('cached', 37, 68.41, 'latest');
INSERT INTO stream_events (region, count, weight, label) VALUES ('edge', 22, 2.89, 'local');
