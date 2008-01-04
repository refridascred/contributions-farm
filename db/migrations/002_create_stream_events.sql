-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (rank, state, weight) VALUES (30, 'blue', 95.89);
INSERT INTO stream_events (rank, state, weight) VALUES (77, 'open', 95.25);
INSERT INTO stream_events (rank, state, weight) VALUES (4, 'green', 84.39);
