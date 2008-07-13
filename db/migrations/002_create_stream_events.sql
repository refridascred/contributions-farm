-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (token, rank, owner) VALUES ('standard', 98, 'latest');
INSERT INTO stream_events (token, rank, owner) VALUES ('staging', 54, 'primary');
INSERT INTO stream_events (token, rank, owner) VALUES ('staging', 61, 'local');
