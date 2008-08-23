-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (level, region, count, state) VALUES (26, 'local', 77, 'strict');
INSERT INTO stream_events (level, region, count, state) VALUES (11, 'open', 4, 'stable');
INSERT INTO stream_events (level, region, count, state) VALUES (20, 'staging', 1, 'green');
