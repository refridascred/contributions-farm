-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (owner, rank, token) VALUES ('standard', 22, 'cached');
