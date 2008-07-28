-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, weight, level) VALUES ('staging', 31.5, 67);
INSERT INTO stream_events (label, weight, level) VALUES ('green', 47.65, 25);
