-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (active, weight, state) VALUES (18, 65.16, 'primary');
INSERT INTO stream_events (active, weight, state) VALUES (78, 88.49, 'staging');
INSERT INTO stream_events (active, weight, state) VALUES (14, 61.67, 'latest');
