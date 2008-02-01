-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (rank, state, weight) VALUES (98, 'latest', 19.23);
INSERT INTO stream_events (rank, state, weight) VALUES (28, 'latest', 61.78);
INSERT INTO stream_events (rank, state, weight) VALUES (79, 'edge', 65.79);
