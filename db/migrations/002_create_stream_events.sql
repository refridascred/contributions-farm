-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (owner, weight, score, label, state) VALUES ('blue', 11.79, 98.14, 'eu-west', 'green');
INSERT INTO stream_events (owner, weight, score, label, state) VALUES ('standard', 79.26, 3.34, 'latest', 'green');
