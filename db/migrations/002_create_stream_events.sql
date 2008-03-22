-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, count, state, ratio) VALUES ('primary', 72, 'blue', 23.15);
INSERT INTO stream_events (region, count, state, ratio) VALUES ('fallback', 85, 'green', 87.12);
