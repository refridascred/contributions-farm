-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (region, label, weight) VALUES ('eu-west', 'latest', 39.0);
INSERT INTO stream_events (region, label, weight) VALUES ('staging', 'eu-west', 81.1);
