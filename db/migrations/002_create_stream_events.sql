-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, state) VALUES (34.79, 'standard');
INSERT INTO stream_events (weight, state) VALUES (31.23, 'green');
