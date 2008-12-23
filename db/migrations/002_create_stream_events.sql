-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    token TEXT,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, label, token, region, ratio) VALUES (33.31, 'fallback', 'local', 'legacy', 25.25);
INSERT INTO stream_events (weight, label, token, region, ratio) VALUES (43.44, 'strict', 'cached', 'standard', 81.65);
