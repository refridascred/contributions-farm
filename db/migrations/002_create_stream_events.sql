-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (owner, score, region, weight) VALUES ('staging', 17.94, 'stable', 24.59);
INSERT INTO stream_events (owner, score, region, weight) VALUES ('local', 47.05, 'blue', 93.76);
