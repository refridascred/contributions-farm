-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (state, owner, score) VALUES ('green', 'cached', 2.97);
INSERT INTO stream_events (state, owner, score) VALUES ('eu-west', 'green', 96.79);
INSERT INTO stream_events (state, owner, score) VALUES ('eu-west', 'blue', 16.25);
