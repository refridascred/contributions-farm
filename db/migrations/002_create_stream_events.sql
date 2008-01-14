-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (weight, owner, ratio, label) VALUES (25.31, 'staging', 83.31, 'stable');
INSERT INTO stream_events (weight, owner, ratio, label) VALUES (10.09, 'blue', 71.42, 'local');
