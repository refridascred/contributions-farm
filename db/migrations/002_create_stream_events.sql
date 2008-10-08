-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    owner TEXT NOT NULL,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, label, owner, weight, count) VALUES ('green', 'green', 'open', 0.04, 57);
INSERT INTO stream_events (state, label, owner, weight, count) VALUES ('blue', 'standard', 'local', 96.08, 73);
