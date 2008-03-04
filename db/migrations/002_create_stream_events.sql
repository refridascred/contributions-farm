-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (region, ratio, label) VALUES ('latest', 32.48, 'local');
INSERT INTO stream_events (region, ratio, label) VALUES ('latest', 88.34, 'fallback');
