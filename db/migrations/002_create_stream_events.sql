-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (token, label, active, region, weight) VALUES ('legacy', 'open', 29, 'strict', 41.63);
INSERT INTO stream_events (token, label, active, region, weight) VALUES ('local', 'open', 57, 'green', 13.99);
INSERT INTO stream_events (token, label, active, region, weight) VALUES ('blue', 'primary', 30, 'local', 28.15);
