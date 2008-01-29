-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, ratio, region) VALUES ('blue', 0.03, 'green');
INSERT INTO stream_events (owner, ratio, region) VALUES ('standard', 1.5, 'eu-west');
