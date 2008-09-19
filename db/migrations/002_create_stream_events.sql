-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (token, score, owner, label, state) VALUES ('eu-west', 65.65, 'standard', 'open', 'strict');
INSERT INTO stream_events (token, score, owner, label, state) VALUES ('cached', 11.23, 'primary', 'stable', 'local');
