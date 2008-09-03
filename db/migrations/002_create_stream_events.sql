-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, level, label) VALUES (49.08, 64, 'latest');
INSERT INTO stream_events (ratio, level, label) VALUES (64.62, 66, 'primary');
