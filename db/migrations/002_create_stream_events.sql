-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (ratio, active, rank, state, weight) VALUES (21.05, 27, 33, 'eu-west', 94.3);
INSERT INTO stream_events (ratio, active, rank, state, weight) VALUES (15.47, 68, 36, 'legacy', 30.07);
