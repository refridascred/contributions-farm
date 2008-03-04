-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    region TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (level, weight, region, label, state) VALUES (41, 50.54, 'stable', 'green', 'blue');
INSERT INTO stream_events (level, weight, region, label, state) VALUES (93, 74.56, 'edge', 'eu-west', 'open');
INSERT INTO stream_events (level, weight, region, label, state) VALUES (72, 52.01, 'green', 'green', 'fallback');
