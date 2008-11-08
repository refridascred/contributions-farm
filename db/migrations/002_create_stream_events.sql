-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (state, weight, owner) VALUES ('legacy', 64.96, 'primary');
INSERT INTO stream_events (state, weight, owner) VALUES ('latest', 29.14, 'open');
INSERT INTO stream_events (state, weight, owner) VALUES ('edge', 8.68, 'staging');
