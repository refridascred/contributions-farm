-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (owner, active, weight, state) VALUES ('cached', 78, 77.25, 'legacy');
INSERT INTO stream_events (owner, active, weight, state) VALUES ('open', 18, 5.32, 'cached');
INSERT INTO stream_events (owner, active, weight, state) VALUES ('edge', 56, 40.08, 'staging');
