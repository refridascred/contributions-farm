-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, count, label, weight, level) VALUES (39.38, 48, 'strict', 17.82, 0);
INSERT INTO stream_events (ratio, count, label, weight, level) VALUES (26.61, 1, 'legacy', 3.75, 60);
