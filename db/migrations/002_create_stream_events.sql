-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (state, weight) VALUES ('stable', 72.53);
INSERT INTO stream_events (state, weight) VALUES ('stable', 92.44);
INSERT INTO stream_events (state, weight) VALUES ('edge', 65.57);
