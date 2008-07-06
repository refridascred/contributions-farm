-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, active, rank, token) VALUES (94, 93, 97, 'strict');
INSERT INTO stream_events (level, active, rank, token) VALUES (86, 44, 44, 'open');
INSERT INTO stream_events (level, active, rank, token) VALUES (90, 43, 69, 'local');
