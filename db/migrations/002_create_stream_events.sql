-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (count, weight, level, ratio) VALUES (91, 60.86, 42, 58.36);
INSERT INTO stream_events (count, weight, level, ratio) VALUES (24, 27.61, 31, 80.38);
