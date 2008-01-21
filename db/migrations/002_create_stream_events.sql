-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, ratio, state, label) VALUES ('local', 65.04, 'cached', 'standard');
INSERT INTO stream_events (owner, ratio, state, label) VALUES ('strict', 55.78, 'cached', 'latest');
