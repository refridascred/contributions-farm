-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, weight, label) VALUES ('green', 0.3, 'cached');
INSERT INTO stream_events (region, weight, label) VALUES ('eu-west', 70.5, 'primary');
INSERT INTO stream_events (region, weight, label) VALUES ('legacy', 40.86, 'latest');
