-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (score, level, state, ratio, rank) VALUES (4.26, 24, 'local', 17.22, 76);
INSERT INTO stream_events (score, level, state, ratio, rank) VALUES (70.97, 94, 'cached', 11.41, 94);
