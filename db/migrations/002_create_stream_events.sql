-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (rank, active, token, count, owner) VALUES (81, 43, 'blue', 37, 'open');
INSERT INTO stream_events (rank, active, token, count, owner) VALUES (1, 67, 'legacy', 51, 'open');
INSERT INTO stream_events (rank, active, token, count, owner) VALUES (59, 90, 'local', 83, 'blue');
