-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (weight, owner, state) VALUES (74.77, 'staging', 'open');
INSERT INTO stream_events (weight, owner, state) VALUES (25.73, 'cached', 'local');
INSERT INTO stream_events (weight, owner, state) VALUES (45.06, 'latest', 'eu-west');
