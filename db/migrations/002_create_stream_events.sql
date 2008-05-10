-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (owner, label, weight, state) VALUES ('legacy', 'blue', 43.89, 'edge');
INSERT INTO stream_events (owner, label, weight, state) VALUES ('open', 'cached', 64.22, 'local');
