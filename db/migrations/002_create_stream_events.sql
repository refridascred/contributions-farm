-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (weight, label, state) VALUES (68.73, 'green', 'primary');
INSERT INTO stream_events (weight, label, state) VALUES (97.17, 'blue', 'blue');
INSERT INTO stream_events (weight, label, state) VALUES (76.18, 'primary', 'green');
