-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, label) VALUES (11.65, 'staging');
INSERT INTO stream_events (weight, label) VALUES (71.86, 'standard');
INSERT INTO stream_events (weight, label) VALUES (96.33, 'fallback');
