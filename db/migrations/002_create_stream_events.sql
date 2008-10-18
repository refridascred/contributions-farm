-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (level, score, state, region, rank) VALUES (36, 44.95, 'stable', 'local', 78);
INSERT INTO stream_events (level, score, state, region, rank) VALUES (88, 64.67, 'cached', 'strict', 28);
INSERT INTO stream_events (level, score, state, region, rank) VALUES (18, 92.07, 'strict', 'latest', 69);
