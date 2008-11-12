-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (label, region, token) VALUES ('latest', 'cached', 'strict');
INSERT INTO stream_events (label, region, token) VALUES ('standard', 'stable', 'latest');
INSERT INTO stream_events (label, region, token) VALUES ('local', 'primary', 'legacy');
