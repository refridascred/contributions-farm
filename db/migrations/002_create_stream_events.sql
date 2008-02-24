-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (rank, label, weight) VALUES (81, 'edge', 32.28);
INSERT INTO stream_events (rank, label, weight) VALUES (87, 'primary', 46.96);
