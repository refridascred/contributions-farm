-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (region, ratio, count, state) VALUES ('green', 45.51, 2, 'open');
INSERT INTO stream_events (region, ratio, count, state) VALUES ('edge', 11.88, 92, 'cached');
INSERT INTO stream_events (region, ratio, count, state) VALUES ('eu-west', 86.43, 82, 'local');
