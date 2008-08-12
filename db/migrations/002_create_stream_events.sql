-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, score, state, count) VALUES ('latest', 29.55, 'blue', 35);
INSERT INTO stream_events (region, score, state, count) VALUES ('green', 21.23, 'primary', 78);
INSERT INTO stream_events (region, score, state, count) VALUES ('cached', 9.27, 'local', 11);
