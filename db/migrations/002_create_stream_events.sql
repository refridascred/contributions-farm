-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (active, token, rank) VALUES (94, 'strict', 83);
INSERT INTO stream_events (active, token, rank) VALUES (86, 'local', 71);
INSERT INTO stream_events (active, token, rank) VALUES (74, 'latest', 64);
