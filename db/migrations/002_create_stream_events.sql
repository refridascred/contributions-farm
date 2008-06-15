-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, ratio, weight) VALUES ('legacy', 69.86, 29.2);
INSERT INTO stream_events (label, ratio, weight) VALUES ('standard', 32.2, 56.07);
