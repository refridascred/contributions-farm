-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, state, weight, rank) VALUES (67, 'legacy', 50.36, 98);
INSERT INTO stream_events (level, state, weight, rank) VALUES (85, 'standard', 87.41, 80);
INSERT INTO stream_events (level, state, weight, rank) VALUES (10, 'blue', 87.74, 34);
