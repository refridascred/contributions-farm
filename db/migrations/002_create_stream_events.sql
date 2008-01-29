-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (token, label, weight) VALUES ('open', 'primary', 30.61);
INSERT INTO stream_events (token, label, weight) VALUES ('strict', 'staging', 6.65);
INSERT INTO stream_events (token, label, weight) VALUES ('fallback', 'staging', 27.27);
