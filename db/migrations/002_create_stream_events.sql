-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (owner, token, label, region) VALUES ('green', 'fallback', 'latest', 'legacy');
INSERT INTO stream_events (owner, token, label, region) VALUES ('strict', 'blue', 'stable', 'staging');
