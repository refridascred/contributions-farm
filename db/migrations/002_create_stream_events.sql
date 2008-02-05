-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (state, weight) VALUES ('fallback', 0.85);
INSERT INTO stream_events (state, weight) VALUES ('standard', 68.09);
INSERT INTO stream_events (state, weight) VALUES ('primary', 48.8);
