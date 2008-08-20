-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, level, rank, token) VALUES (55, 53, 88, 'blue');
INSERT INTO stream_events (active, level, rank, token) VALUES (63, 88, 40, 'strict');
INSERT INTO stream_events (active, level, rank, token) VALUES (28, 61, 68, 'primary');
