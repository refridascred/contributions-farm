-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (active, label, weight) VALUES (44, 'cached', 24.52);
INSERT INTO stream_events (active, label, weight) VALUES (37, 'green', 56.07);
INSERT INTO stream_events (active, label, weight) VALUES (44, 'staging', 24.57);
