-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, label, token) VALUES ('legacy', 'open', 'strict');
INSERT INTO stream_events (region, label, token) VALUES ('open', 'edge', 'primary');
INSERT INTO stream_events (region, label, token) VALUES ('eu-west', 'edge', 'legacy');
