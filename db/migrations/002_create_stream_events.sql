-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (state, weight, owner) VALUES ('legacy', 87.58, 'blue');
INSERT INTO stream_events (state, weight, owner) VALUES ('edge', 24.5, 'cached');
INSERT INTO stream_events (state, weight, owner) VALUES ('staging', 12.79, 'open');
