-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (rank, token, region, level) VALUES (41, 'green', 'staging', 10);
INSERT INTO stream_events (rank, token, region, level) VALUES (43, 'staging', 'local', 34);
