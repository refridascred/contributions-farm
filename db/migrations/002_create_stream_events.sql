-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (rank, ratio, state, level, weight) VALUES (27, 91.7, 'cached', 77, 0.5);
INSERT INTO stream_events (rank, ratio, state, level, weight) VALUES (21, 93.41, 'primary', 21, 59.56);
