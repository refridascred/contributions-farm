-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (rank, label, owner) VALUES (99, 'latest', 'edge');
INSERT INTO stream_events (rank, label, owner) VALUES (74, 'fallback', 'primary');
