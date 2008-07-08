-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (token, region, label, ratio) VALUES ('open', 'latest', 'primary', 55.75);
INSERT INTO stream_events (token, region, label, ratio) VALUES ('open', 'strict', 'primary', 8.23);
