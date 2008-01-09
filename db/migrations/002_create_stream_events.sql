-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (label, state, owner, weight) VALUES ('legacy', 'eu-west', 'cached', 35.73);
INSERT INTO stream_events (label, state, owner, weight) VALUES ('strict', 'stable', 'blue', 8.14);
