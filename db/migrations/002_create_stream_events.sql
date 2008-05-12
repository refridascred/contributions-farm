-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (rank, state, region, level, score) VALUES (17, 'stable', 'eu-west', 4, 98.58);
INSERT INTO stream_events (rank, state, region, level, score) VALUES (81, 'open', 'latest', 3, 52.78);
