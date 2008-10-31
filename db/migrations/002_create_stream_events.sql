-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (label, active, rank, token, owner) VALUES ('local', 17, 43, 'cached', 'open');
INSERT INTO stream_events (label, active, rank, token, owner) VALUES ('latest', 31, 72, 'stable', 'legacy');
