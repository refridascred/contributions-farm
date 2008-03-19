-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, level, count, state, weight) VALUES ('fallback', 78, 60, 'eu-west', 72.76);
INSERT INTO stream_events (region, level, count, state, weight) VALUES ('cached', 82, 59, 'stable', 31.85);
INSERT INTO stream_events (region, level, count, state, weight) VALUES ('strict', 44, 1, 'legacy', 27.58);
