-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (state, weight, active, rank) VALUES ('standard', 34.19, 46, 57);
INSERT INTO stream_events (state, weight, active, rank) VALUES ('fallback', 35.93, 74, 67);
INSERT INTO stream_events (state, weight, active, rank) VALUES ('standard', 69.72, 58, 42);
