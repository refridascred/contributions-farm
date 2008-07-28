-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    created_at TIMESTAMP,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, weight, token, label) VALUES ('cached', 9.36, 'blue', 'open');
INSERT INTO stream_events (region, weight, token, label) VALUES ('latest', 32.71, 'fallback', 'cached');
INSERT INTO stream_events (region, weight, token, label) VALUES ('stable', 48.06, 'stable', 'edge');
