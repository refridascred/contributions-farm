-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (state, count, ratio, active, region) VALUES ('green', 60, 80.0, 46, 'edge');
INSERT INTO stream_events (state, count, ratio, active, region) VALUES ('local', 37, 86.82, 35, 'eu-west');
INSERT INTO stream_events (state, count, ratio, active, region) VALUES ('primary', 59, 48.61, 51, 'legacy');
