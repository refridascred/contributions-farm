-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, region, ratio) VALUES ('green', 'local', 34.16);
INSERT INTO stream_events (label, region, ratio) VALUES ('local', 'eu-west', 90.18);
INSERT INTO stream_events (label, region, ratio) VALUES ('staging', 'strict', 9.23);
