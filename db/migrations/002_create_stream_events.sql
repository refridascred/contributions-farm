-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    label TEXT,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (ratio, weight, label, region, rank) VALUES (77.84, 20.26, 'edge', 'eu-west', 7);
