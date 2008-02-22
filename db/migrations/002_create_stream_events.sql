-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, level, token) VALUES (88.86, 75, 'cached');
INSERT INTO stream_events (weight, level, token) VALUES (51.93, 97, 'fallback');
INSERT INTO stream_events (weight, level, token) VALUES (1.0, 46, 'open');
