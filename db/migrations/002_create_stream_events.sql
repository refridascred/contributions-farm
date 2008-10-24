-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, ratio, label, region) VALUES ('green', 2.05, 'open', 'legacy');
INSERT INTO stream_events (owner, ratio, label, region) VALUES ('legacy', 97.3, 'strict', 'staging');
INSERT INTO stream_events (owner, ratio, label, region) VALUES ('cached', 39.62, 'cached', 'edge');
