-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (active, ratio, level) VALUES (18, 69.18, 19);
INSERT INTO stream_events (active, ratio, level) VALUES (92, 27.27, 40);
INSERT INTO stream_events (active, ratio, level) VALUES (4, 95.49, 20);
