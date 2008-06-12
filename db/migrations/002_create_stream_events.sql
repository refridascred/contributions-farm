-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (region, count, ratio, state) VALUES ('strict', 76, 17.01, 'stable');
INSERT INTO stream_events (region, count, ratio, state) VALUES ('fallback', 60, 82.96, 'stable');
INSERT INTO stream_events (region, count, ratio, state) VALUES ('blue', 56, 84.05, 'open');
