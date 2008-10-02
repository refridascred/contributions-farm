-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (rank, token, owner, count, label) VALUES (90, 'latest', 'latest', 11, 'primary');
INSERT INTO stream_events (rank, token, owner, count, label) VALUES (79, 'eu-west', 'local', 94, 'standard');
