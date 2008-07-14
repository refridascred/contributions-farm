-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (weight, token, active) VALUES (26.86, 'blue', 44);
INSERT INTO stream_events (weight, token, active) VALUES (51.65, 'blue', 62);
INSERT INTO stream_events (weight, token, active) VALUES (27.49, 'green', 90);
