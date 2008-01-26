-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, label, state, owner) VALUES (48.42, 'eu-west', 'green', 'open');
INSERT INTO stream_events (score, label, state, owner) VALUES (68.57, 'latest', 'primary', 'open');
INSERT INTO stream_events (score, label, state, owner) VALUES (0.46, 'standard', 'local', 'standard');
