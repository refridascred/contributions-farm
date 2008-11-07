-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (state, owner, weight, label) VALUES ('local', 'latest', 86.47, 'edge');
INSERT INTO stream_events (state, owner, weight, label) VALUES ('local', 'green', 60.71, 'legacy');
INSERT INTO stream_events (state, owner, weight, label) VALUES ('latest', 'open', 74.57, 'eu-west');
