-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (active, region, level, ratio) VALUES (99, 'latest', 38, 62.37);
INSERT INTO stream_events (active, region, level, ratio) VALUES (66, 'cached', 79, 50.45);
INSERT INTO stream_events (active, region, level, ratio) VALUES (58, 'standard', 25, 8.09);
