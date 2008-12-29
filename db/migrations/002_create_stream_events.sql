-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (state, score, ratio, label) VALUES ('fallback', 45.62, 16.34, 'cached');
INSERT INTO stream_events (state, score, ratio, label) VALUES ('strict', 18.48, 14.3, 'stable');
INSERT INTO stream_events (state, score, ratio, label) VALUES ('latest', 49.72, 70.58, 'latest');
