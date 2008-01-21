-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (label, ratio, level) VALUES ('staging', 58.29, 87);
