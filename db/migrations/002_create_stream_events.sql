-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    label TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (weight, region, label, rank, count) VALUES (71.03, 'latest', 'primary', 41, 63);
INSERT INTO stream_events (weight, region, label, rank, count) VALUES (86.13, 'standard', 'latest', 0, 74);
