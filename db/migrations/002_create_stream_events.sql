-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, count, owner, label, ratio) VALUES ('staging', 27, 'legacy', 'green', 57.78);
INSERT INTO stream_events (state, count, owner, label, ratio) VALUES ('eu-west', 74, 'latest', 'cached', 24.8);
INSERT INTO stream_events (state, count, owner, label, ratio) VALUES ('eu-west', 39, 'latest', 'local', 1.7);
