-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (rank, level, owner) VALUES (95, 40, 'open');
INSERT INTO stream_events (rank, level, owner) VALUES (26, 2, 'strict');
