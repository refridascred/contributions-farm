-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (rank, owner, token, label) VALUES (33, 'eu-west', 'strict', 'staging');
INSERT INTO stream_events (rank, owner, token, label) VALUES (46, 'stable', 'stable', 'eu-west');
INSERT INTO stream_events (rank, owner, token, label) VALUES (20, 'staging', 'edge', 'primary');
