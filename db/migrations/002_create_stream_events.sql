-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (label, owner, ratio, region) VALUES ('primary', 'green', 95.76, 'local');
INSERT INTO stream_events (label, owner, ratio, region) VALUES ('standard', 'latest', 3.41, 'green');
