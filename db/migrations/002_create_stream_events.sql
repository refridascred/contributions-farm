-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (ratio, score, state, owner, rank) VALUES (0.36, 84.02, 'staging', 'eu-west', 16);
INSERT INTO stream_events (ratio, score, state, owner, rank) VALUES (24.71, 73.48, 'latest', 'green', 66);
