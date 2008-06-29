-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (label, token, rank, owner) VALUES ('open', 'fallback', 88, 'local');
INSERT INTO stream_events (label, token, rank, owner) VALUES ('staging', 'edge', 4, 'open');
