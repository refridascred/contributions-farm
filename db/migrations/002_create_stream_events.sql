-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, weight, owner) VALUES ('primary', 57.4, 'latest');
INSERT INTO stream_events (label, weight, owner) VALUES ('fallback', 57.18, 'blue');
