-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, weight, score, owner) VALUES (33.53, 50.37, 4.52, 'latest');
INSERT INTO stream_events (ratio, weight, score, owner) VALUES (24.46, 44.82, 25.35, 'local');
