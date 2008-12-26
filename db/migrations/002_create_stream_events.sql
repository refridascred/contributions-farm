-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (weight, label, level) VALUES (42.76, 'latest', 31);
INSERT INTO stream_events (weight, label, level) VALUES (27.28, 'stable', 54);
INSERT INTO stream_events (weight, label, level) VALUES (52.63, 'strict', 5);
