-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (rank, ratio, state, weight, level) VALUES (98, 34.95, 'legacy', 79.71, 2);
INSERT INTO stream_events (rank, ratio, state, weight, level) VALUES (52, 30.22, 'cached', 77.24, 88);
