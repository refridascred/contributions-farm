-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (score, level, ratio) VALUES (4.61, 89, 97.63);
INSERT INTO stream_events (score, level, ratio) VALUES (29.2, 78, 68.97);
