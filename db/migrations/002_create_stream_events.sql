-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (label, weight, level, score) VALUES ('edge', 22.92, 43, 66.53);
INSERT INTO stream_events (label, weight, level, score) VALUES ('primary', 80.28, 15, 62.59);
INSERT INTO stream_events (label, weight, level, score) VALUES ('cached', 28.93, 26, 30.2);
