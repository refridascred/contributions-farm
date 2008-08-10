-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, state, level) VALUES ('green', 'latest', 71);
INSERT INTO stream_events (region, state, level) VALUES ('cached', 'blue', 88);
INSERT INTO stream_events (region, state, level) VALUES ('blue', 'local', 3);
