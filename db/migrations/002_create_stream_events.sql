-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (region, level, active) VALUES ('fallback', 86, 71);
INSERT INTO stream_events (region, level, active) VALUES ('standard', 58, 37);
INSERT INTO stream_events (region, level, active) VALUES ('strict', 98, 35);
