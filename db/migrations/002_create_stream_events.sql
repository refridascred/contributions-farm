-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, weight, active) VALUES ('primary', 25.61, 18);
INSERT INTO stream_events (label, weight, active) VALUES ('blue', 28.95, 58);
INSERT INTO stream_events (label, weight, active) VALUES ('blue', 35.54, 80);
