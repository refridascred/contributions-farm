-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (weight, token, label) VALUES (95.05, 'local', 'green');
INSERT INTO stream_events (weight, token, label) VALUES (41.11, 'open', 'blue');
INSERT INTO stream_events (weight, token, label) VALUES (32.85, 'strict', 'edge');
