-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (rank, score, active, weight, state) VALUES (33, 30.56, 77, 11.79, 'staging');
