-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, region, weight, level) VALUES ('blue', 'legacy', 25.53, 74);
INSERT INTO stream_events (label, region, weight, level) VALUES ('fallback', 'blue', 66.02, 58);
INSERT INTO stream_events (label, region, weight, level) VALUES ('latest', 'strict', 39.02, 80);
