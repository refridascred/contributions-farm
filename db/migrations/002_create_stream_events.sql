-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (weight, label, region) VALUES (64.07, 'primary', 'local');
INSERT INTO stream_events (weight, label, region) VALUES (37.5, 'local', 'local');
INSERT INTO stream_events (weight, label, region) VALUES (88.52, 'green', 'green');
