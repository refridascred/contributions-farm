-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (label, token, weight) VALUES ('green', 'blue', 42.52);
INSERT INTO stream_events (label, token, weight) VALUES ('staging', 'staging', 91.88);
INSERT INTO stream_events (label, token, weight) VALUES ('local', 'cached', 1.04);
