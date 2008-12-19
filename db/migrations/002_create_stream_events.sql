-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, region, ratio, owner, level) VALUES ('standard', 'edge', 31.3, 'blue', 10);
INSERT INTO stream_events (state, region, ratio, owner, level) VALUES ('green', 'cached', 23.5, 'strict', 63);
INSERT INTO stream_events (state, region, ratio, owner, level) VALUES ('green', 'fallback', 45.16, 'local', 99);
