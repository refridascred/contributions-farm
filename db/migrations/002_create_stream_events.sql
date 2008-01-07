-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (owner, label, state, score) VALUES ('staging', 'standard', 'cached', 68.69);
INSERT INTO stream_events (owner, label, state, score) VALUES ('eu-west', 'cached', 'local', 95.11);
