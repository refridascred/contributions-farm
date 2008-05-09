-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, state, rank) VALUES (68.81, 'blue', 8);
INSERT INTO stream_events (weight, state, rank) VALUES (74.67, 'legacy', 2);
INSERT INTO stream_events (weight, state, rank) VALUES (53.0, 'cached', 45);
