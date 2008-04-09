-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (owner, token, rank) VALUES ('edge', 'cached', 19);
INSERT INTO stream_events (owner, token, rank) VALUES ('fallback', 'open', 71);
