-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (ratio, score, token) VALUES (14.65, 53.47, 'stable');
INSERT INTO stream_events (ratio, score, token) VALUES (44.94, 59.73, 'latest');
INSERT INTO stream_events (ratio, score, token) VALUES (68.66, 27.98, 'cached');
