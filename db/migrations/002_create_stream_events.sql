-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    ratio REAL,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (state, level, ratio, weight) VALUES ('green', 11, 48.79, 36.61);
INSERT INTO stream_events (state, level, ratio, weight) VALUES ('blue', 44, 89.28, 45.49);
INSERT INTO stream_events (state, level, ratio, weight) VALUES ('open', 28, 21.91, 47.41);
