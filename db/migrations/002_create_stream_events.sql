-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (ratio, weight, label) VALUES (73.81, 57.04, 'green');
INSERT INTO stream_events (ratio, weight, label) VALUES (35.65, 22.3, 'primary');
