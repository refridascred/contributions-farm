-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (label, ratio, level) VALUES ('standard', 35.09, 3);
INSERT INTO stream_events (label, ratio, level) VALUES ('strict', 8.63, 40);
INSERT INTO stream_events (label, ratio, level) VALUES ('fallback', 32.23, 27);
