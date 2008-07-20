-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (ratio, level, rank, score, state) VALUES (91.82, 28, 27, 2.16, 'latest');
INSERT INTO stream_events (ratio, level, rank, score, state) VALUES (4.45, 25, 0, 15.95, 'fallback');
INSERT INTO stream_events (ratio, level, rank, score, state) VALUES (9.84, 65, 26, 16.83, 'fallback');
