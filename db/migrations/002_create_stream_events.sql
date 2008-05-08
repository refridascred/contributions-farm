-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (owner, ratio, rank, state) VALUES ('edge', 60.55, 57, 'eu-west');
INSERT INTO stream_events (owner, ratio, rank, state) VALUES ('primary', 26.58, 66, 'blue');
