-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (state, level, label, region) VALUES ('blue', 34, 'fallback', 'eu-west');
INSERT INTO stream_events (state, level, label, region) VALUES ('green', 76, 'cached', 'stable');
INSERT INTO stream_events (state, level, label, region) VALUES ('blue', 87, 'primary', 'edge');
