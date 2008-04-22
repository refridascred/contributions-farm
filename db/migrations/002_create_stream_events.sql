-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, label) VALUES ('latest', 'local');
INSERT INTO stream_events (region, label) VALUES ('eu-west', 'local');
INSERT INTO stream_events (region, label) VALUES ('open', 'strict');
