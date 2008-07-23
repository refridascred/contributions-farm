-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (weight, score, ratio, level, owner) VALUES (9.75, 47.75, 15.46, 99, 'latest');
INSERT INTO stream_events (weight, score, ratio, level, owner) VALUES (60.99, 94.95, 16.29, 9, 'standard');
