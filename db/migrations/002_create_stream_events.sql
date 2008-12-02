-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (owner, score, level, token, ratio) VALUES ('fallback', 70.72, 90, 'open', 96.72);
INSERT INTO stream_events (owner, score, level, token, ratio) VALUES ('stable', 47.57, 30, 'stable', 77.78);
INSERT INTO stream_events (owner, score, level, token, ratio) VALUES ('cached', 68.87, 52, 'blue', 71.35);
