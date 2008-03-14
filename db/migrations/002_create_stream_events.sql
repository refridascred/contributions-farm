-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (count, label, region, level, ratio) VALUES (6, 'edge', 'legacy', 97, 15.96);
INSERT INTO stream_events (count, label, region, level, ratio) VALUES (92, 'latest', 'cached', 27, 57.29);
INSERT INTO stream_events (count, label, region, level, ratio) VALUES (96, 'legacy', 'stable', 27, 78.69);
