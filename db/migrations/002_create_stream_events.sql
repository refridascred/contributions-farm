-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, weight, region) VALUES ('stable', 16.31, 'staging');
INSERT INTO stream_events (label, weight, region) VALUES ('staging', 91.34, 'eu-west');
INSERT INTO stream_events (label, weight, region) VALUES ('strict', 2.45, 'primary');
