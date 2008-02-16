-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, token, region) VALUES (1, 'stable', 'standard');
INSERT INTO stream_events (level, token, region) VALUES (47, 'staging', 'green');
INSERT INTO stream_events (level, token, region) VALUES (18, 'blue', 'primary');
