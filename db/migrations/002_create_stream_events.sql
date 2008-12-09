-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (state, active, rank, weight) VALUES ('latest', 28, 53, 20.5);
INSERT INTO stream_events (state, active, rank, weight) VALUES ('primary', 97, 21, 89.52);
INSERT INTO stream_events (state, active, rank, weight) VALUES ('fallback', 36, 83, 48.42);
