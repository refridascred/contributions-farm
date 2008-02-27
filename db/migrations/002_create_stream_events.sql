-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, token, owner, count) VALUES (57, 'eu-west', 'strict', 64);
INSERT INTO stream_events (rank, token, owner, count) VALUES (10, 'blue', 'staging', 72);
INSERT INTO stream_events (rank, token, owner, count) VALUES (1, 'standard', 'primary', 13);
