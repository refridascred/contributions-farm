-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (state, rank, score, region, level) VALUES ('legacy', 90, 25.99, 'primary', 45);
INSERT INTO stream_events (state, rank, score, region, level) VALUES ('local', 49, 94.07, 'edge', 37);
