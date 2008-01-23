-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (rank, level, owner) VALUES (94, 58, 'fallback');
INSERT INTO stream_events (rank, level, owner) VALUES (45, 55, 'green');
