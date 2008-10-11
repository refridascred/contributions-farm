-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (weight, region, label) VALUES (59.95, 'edge', 'green');
INSERT INTO stream_events (weight, region, label) VALUES (72.3, 'edge', 'fallback');
