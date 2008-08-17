-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (rank, label, weight, region) VALUES (8, 'standard', 95.48, 'green');
INSERT INTO stream_events (rank, label, weight, region) VALUES (11, 'stable', 35.25, 'green');
INSERT INTO stream_events (rank, label, weight, region) VALUES (34, 'legacy', 54.8, 'cached');
