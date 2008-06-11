-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    token TEXT,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (region, ratio, token, level, owner) VALUES ('green', 84.97, 'cached', 69, 'strict');
INSERT INTO stream_events (region, ratio, token, level, owner) VALUES ('legacy', 31.07, 'edge', 71, 'open');
