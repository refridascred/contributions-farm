-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (owner, label, weight, level) VALUES ('strict', 'stable', 35.18, 1);
INSERT INTO stream_events (owner, label, weight, level) VALUES ('primary', 'standard', 63.49, 27);
