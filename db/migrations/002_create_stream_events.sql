-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, weight, token) VALUES ('local', 69.38, 'standard');
INSERT INTO stream_events (label, weight, token) VALUES ('standard', 67.71, 'eu-west');
INSERT INTO stream_events (label, weight, token) VALUES ('primary', 17.2, 'open');
