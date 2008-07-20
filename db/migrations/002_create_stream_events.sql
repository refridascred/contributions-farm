-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (owner, level, weight, score) VALUES ('cached', 47, 32.21, 35.42);
INSERT INTO stream_events (owner, level, weight, score) VALUES ('primary', 62, 13.33, 67.62);
