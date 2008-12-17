-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (token, level, ratio, state, rank) VALUES ('stable', 59, 59.72, 'standard', 95);
INSERT INTO stream_events (token, level, ratio, state, rank) VALUES ('legacy', 32, 67.32, 'fallback', 17);
INSERT INTO stream_events (token, level, ratio, state, rank) VALUES ('primary', 53, 45.17, 'primary', 67);
