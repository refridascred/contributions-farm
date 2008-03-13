-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (owner, score, label, state, ratio) VALUES ('eu-west', 77.67, 'cached', 'green', 23.69);
INSERT INTO stream_events (owner, score, label, state, ratio) VALUES ('cached', 97.28, 'green', 'open', 87.31);
