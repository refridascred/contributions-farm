-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (score, weight, level, state, label) VALUES (59.87, 84.9, 93, 'staging', 'staging');
INSERT INTO stream_events (score, weight, level, state, label) VALUES (36.9, 26.52, 47, 'staging', 'open');
INSERT INTO stream_events (score, weight, level, state, label) VALUES (77.37, 96.12, 47, 'staging', 'standard');
