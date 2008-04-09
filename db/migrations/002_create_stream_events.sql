-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (label, weight, token, region) VALUES ('local', 4.75, 'open', 'legacy');
INSERT INTO stream_events (label, weight, token, region) VALUES ('stable', 8.77, 'blue', 'primary');
