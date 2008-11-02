-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    level INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, region, level, token, state) VALUES (60.64, 'legacy', 69, 'green', 'primary');
INSERT INTO stream_events (weight, region, level, token, state) VALUES (98.98, 'edge', 64, 'legacy', 'fallback');
INSERT INTO stream_events (weight, region, level, token, state) VALUES (12.33, 'eu-west', 9, 'local', 'local');
