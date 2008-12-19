-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    owner TEXT NOT NULL,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (state, ratio, owner, weight) VALUES ('standard', 93.39, 'primary', 1.5);
INSERT INTO stream_events (state, ratio, owner, weight) VALUES ('stable', 21.58, 'blue', 72.78);
INSERT INTO stream_events (state, ratio, owner, weight) VALUES ('edge', 39.86, 'stable', 3.21);
