-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, state, owner) VALUES (22.33, 'local', 'primary');
INSERT INTO stream_events (weight, state, owner) VALUES (86.91, 'cached', 'stable');
INSERT INTO stream_events (weight, state, owner) VALUES (27.44, 'cached', 'latest');
