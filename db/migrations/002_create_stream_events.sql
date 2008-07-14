-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    token TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (rank, level, token, owner) VALUES (97, 60, 'cached', 'latest');
INSERT INTO stream_events (rank, level, token, owner) VALUES (19, 32, 'stable', 'primary');
