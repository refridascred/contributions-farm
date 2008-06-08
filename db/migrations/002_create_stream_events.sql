-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (label, owner, region) VALUES ('edge', 'primary', 'legacy');
INSERT INTO stream_events (label, owner, region) VALUES ('local', 'blue', 'eu-west');
INSERT INTO stream_events (label, owner, region) VALUES ('eu-west', 'stable', 'cached');
