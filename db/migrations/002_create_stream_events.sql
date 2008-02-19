-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (region, level, state, label, score) VALUES ('blue', 66, 'eu-west', 'blue', 61.78);
INSERT INTO stream_events (region, level, state, label, score) VALUES ('green', 55, 'stable', 'edge', 1.67);
INSERT INTO stream_events (region, level, state, label, score) VALUES ('strict', 49, 'eu-west', 'open', 19.54);
