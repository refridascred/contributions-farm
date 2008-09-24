-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    ratio REAL,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (state, owner, ratio, weight, label) VALUES ('edge', 'strict', 0.09, 36.8, 'stable');
INSERT INTO stream_events (state, owner, ratio, weight, label) VALUES ('open', 'staging', 40.92, 79.68, 'legacy');
INSERT INTO stream_events (state, owner, ratio, weight, label) VALUES ('staging', 'strict', 98.4, 13.0, 'blue');
