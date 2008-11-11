-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (region, owner, score, ratio) VALUES ('blue', 'primary', 90.63, 66.48);
INSERT INTO stream_events (region, owner, score, ratio) VALUES ('cached', 'stable', 39.08, 65.71);
