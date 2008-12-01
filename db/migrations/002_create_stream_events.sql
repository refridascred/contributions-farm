-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (owner, active, weight, label) VALUES ('standard', 72, 74.62, 'green');
INSERT INTO stream_events (owner, active, weight, label) VALUES ('standard', 51, 97.24, 'green');
INSERT INTO stream_events (owner, active, weight, label) VALUES ('strict', 51, 84.4, 'latest');
