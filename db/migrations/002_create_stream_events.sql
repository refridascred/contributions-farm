-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (ratio, state, weight, label) VALUES (5.1, 'blue', 27.38, 'stable');
INSERT INTO stream_events (ratio, state, weight, label) VALUES (76.07, 'blue', 47.26, 'green');
