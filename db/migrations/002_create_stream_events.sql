-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (state, weight, rank, owner) VALUES ('fallback', 78.41, 43, 'standard');
INSERT INTO stream_events (state, weight, rank, owner) VALUES ('latest', 0.62, 5, 'local');
INSERT INTO stream_events (state, weight, rank, owner) VALUES ('staging', 75.04, 22, 'blue');
