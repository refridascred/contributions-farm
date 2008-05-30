-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (region, level, score) VALUES ('legacy', 96, 20.75);
INSERT INTO stream_events (region, level, score) VALUES ('stable', 57, 53.78);
INSERT INTO stream_events (region, level, score) VALUES ('cached', 62, 66.88);
