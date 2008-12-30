-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (state, score, rank, owner, label) VALUES ('eu-west', 40.71, 31, 'strict', 'stable');
INSERT INTO stream_events (state, score, rank, owner, label) VALUES ('legacy', 88.4, 45, 'legacy', 'eu-west');
