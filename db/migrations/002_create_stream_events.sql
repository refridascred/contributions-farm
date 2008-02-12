-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (rank, level, count, token) VALUES (3, 19, 54, 'legacy');
INSERT INTO stream_events (rank, level, count, token) VALUES (40, 60, 9, 'stable');
INSERT INTO stream_events (rank, level, count, token) VALUES (76, 55, 10, 'primary');
