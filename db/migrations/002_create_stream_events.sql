-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (token, label, active, rank, owner) VALUES ('legacy', 'cached', 9, 78, 'latest');
INSERT INTO stream_events (token, label, active, rank, owner) VALUES ('edge', 'eu-west', 24, 92, 'standard');
