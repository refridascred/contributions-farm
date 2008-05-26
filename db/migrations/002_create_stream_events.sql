-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, state, weight) VALUES (90.34, 'latest', 37.24);
INSERT INTO stream_events (ratio, state, weight) VALUES (41.63, 'stable', 97.38);
INSERT INTO stream_events (ratio, state, weight) VALUES (47.05, 'staging', 92.03);
