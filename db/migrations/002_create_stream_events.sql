-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (level, token, region) VALUES (11, 'cached', 'blue');
INSERT INTO stream_events (level, token, region) VALUES (54, 'primary', 'latest');
INSERT INTO stream_events (level, token, region) VALUES (76, 'latest', 'green');
