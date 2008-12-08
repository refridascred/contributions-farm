-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, state, active, ratio) VALUES (68.5, 'green', 96, 15.76);
INSERT INTO stream_events (weight, state, active, ratio) VALUES (34.18, 'eu-west', 91, 40.88);
INSERT INTO stream_events (weight, state, active, ratio) VALUES (41.36, 'staging', 90, 91.5);
