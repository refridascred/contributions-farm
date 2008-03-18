-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    owner TEXT NOT NULL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (active, label, owner, weight, state) VALUES (97, 'primary', 'cached', 15.59, 'green');
INSERT INTO stream_events (active, label, owner, weight, state) VALUES (68, 'open', 'primary', 71.27, 'cached');
