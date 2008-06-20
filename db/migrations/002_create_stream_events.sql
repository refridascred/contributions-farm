-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, label, ratio, count) VALUES (80, 'eu-west', 4.82, 10);
INSERT INTO stream_events (level, label, ratio, count) VALUES (54, 'strict', 63.81, 17);
