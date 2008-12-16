-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (rank, weight, label) VALUES (81, 95.86, 'fallback');
INSERT INTO stream_events (rank, weight, label) VALUES (66, 43.18, 'legacy');
INSERT INTO stream_events (rank, weight, label) VALUES (21, 3.6, 'legacy');
