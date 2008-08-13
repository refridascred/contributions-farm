-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (weight, label, level) VALUES (15.48, 'open', 70);
INSERT INTO stream_events (weight, label, level) VALUES (31.06, 'latest', 6);
