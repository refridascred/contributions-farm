-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, weight, region) VALUES (51, 4.97, 'legacy');
INSERT INTO stream_events (level, weight, region) VALUES (22, 23.58, 'standard');
