-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (region, state, count) VALUES ('cached', 'local', 35);
INSERT INTO stream_events (region, state, count) VALUES ('stable', 'stable', 39);
INSERT INTO stream_events (region, state, count) VALUES ('green', 'primary', 89);
