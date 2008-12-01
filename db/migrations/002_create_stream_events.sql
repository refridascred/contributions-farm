-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    token TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, level, token, ratio, weight) VALUES (57, 25, 'local', 70.15, 65.56);
INSERT INTO stream_events (count, level, token, ratio, weight) VALUES (72, 14, 'local', 7.69, 59.73);
