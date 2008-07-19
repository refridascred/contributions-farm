-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    weight REAL,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (region, token, weight, level) VALUES ('staging', 'latest', 7.01, 86);
INSERT INTO stream_events (region, token, weight, level) VALUES ('primary', 'strict', 77.41, 72);
INSERT INTO stream_events (region, token, weight, level) VALUES ('legacy', 'cached', 71.34, 82);
