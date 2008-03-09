-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    token TEXT,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (count, level, token, region, ratio) VALUES (43, 23, 'local', 'local', 87.32);
INSERT INTO stream_events (count, level, token, region, ratio) VALUES (38, 35, 'blue', 'blue', 22.32);
INSERT INTO stream_events (count, level, token, region, ratio) VALUES (61, 86, 'strict', 'legacy', 3.02);
