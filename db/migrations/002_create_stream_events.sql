-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (label, score, owner, state) VALUES ('cached', 21.37, 'standard', 'primary');
INSERT INTO stream_events (label, score, owner, state) VALUES ('primary', 14.94, 'cached', 'eu-west');
INSERT INTO stream_events (label, score, owner, state) VALUES ('stable', 9.29, 'open', 'blue');
