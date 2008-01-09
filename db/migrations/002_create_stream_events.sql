-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    token TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, rank, token, weight, ratio) VALUES (34, 58, 'cached', 56.79, 34.23);
