-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (token, rank, active, owner, state) VALUES ('blue', 45, 91, 'stable', 'local');
INSERT INTO stream_events (token, rank, active, owner, state) VALUES ('staging', 4, 69, 'standard', 'edge');
