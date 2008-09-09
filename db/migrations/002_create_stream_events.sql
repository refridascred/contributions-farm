-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (weight, state, count, level, region) VALUES (46.61, 'green', 37, 46, 'latest');
INSERT INTO stream_events (weight, state, count, level, region) VALUES (4.23, 'fallback', 90, 44, 'latest');
INSERT INTO stream_events (weight, state, count, level, region) VALUES (5.58, 'green', 96, 94, 'eu-west');
