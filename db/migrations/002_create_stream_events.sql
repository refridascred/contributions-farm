-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    created_at TIMESTAMP,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (rank, weight, label, region) VALUES (62, 71.0, 'cached', 'eu-west');
INSERT INTO stream_events (rank, weight, label, region) VALUES (69, 9.81, 'legacy', 'primary');
INSERT INTO stream_events (rank, weight, label, region) VALUES (89, 53.29, 'standard', 'green');
