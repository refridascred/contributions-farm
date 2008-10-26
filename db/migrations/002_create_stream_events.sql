-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (ratio, level, owner, rank) VALUES (95.22, 10, 'fallback', 90);
INSERT INTO stream_events (ratio, level, owner, rank) VALUES (52.85, 38, 'cached', 56);
