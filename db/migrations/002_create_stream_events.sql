-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, level, label, state) VALUES (44.92, 27, 'edge', 'open');
INSERT INTO stream_events (weight, level, label, state) VALUES (65.03, 57, 'edge', 'standard');
INSERT INTO stream_events (weight, level, label, state) VALUES (98.14, 96, 'eu-west', 'stable');
