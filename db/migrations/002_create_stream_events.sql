-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    created_at TIMESTAMP,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (token, level, weight, region) VALUES ('open', 84, 63.87, 'legacy');
INSERT INTO stream_events (token, level, weight, region) VALUES ('strict', 81, 19.15, 'latest');
INSERT INTO stream_events (token, level, weight, region) VALUES ('green', 39, 16.8, 'eu-west');
