-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (count, ratio, weight, state) VALUES (43, 94.36, 63.75, 'edge');
INSERT INTO stream_events (count, ratio, weight, state) VALUES (19, 12.36, 60.72, 'local');
INSERT INTO stream_events (count, ratio, weight, state) VALUES (24, 46.23, 89.0, 'fallback');
