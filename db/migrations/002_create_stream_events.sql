-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    level INTEGER,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, weight, level, ratio, owner) VALUES ('primary', 2.46, 64, 49.13, 'open');
INSERT INTO stream_events (label, weight, level, ratio, owner) VALUES ('legacy', 83.25, 6, 39.83, 'staging');
