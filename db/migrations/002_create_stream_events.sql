-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (owner, ratio, rank, level) VALUES ('fallback', 70.71, 14, 83);
INSERT INTO stream_events (owner, ratio, rank, level) VALUES ('local', 25.19, 13, 31);
