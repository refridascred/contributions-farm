-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (ratio, state, weight, owner, score) VALUES (46.68, 'fallback', 82.66, 'staging', 30.17);
INSERT INTO stream_events (ratio, state, weight, owner, score) VALUES (33.25, 'edge', 0.96, 'open', 59.25);
INSERT INTO stream_events (ratio, state, weight, owner, score) VALUES (3.25, 'cached', 65.08, 'latest', 4.61);
