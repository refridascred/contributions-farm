-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (region, score, weight, owner, level) VALUES ('staging', 74.08, 29.51, 'stable', 71);
INSERT INTO stream_events (region, score, weight, owner, level) VALUES ('strict', 2.09, 73.53, 'standard', 15);
INSERT INTO stream_events (region, score, weight, owner, level) VALUES ('open', 24.76, 92.09, 'standard', 53);
