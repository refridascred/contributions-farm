-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (token, label, state, weight, level) VALUES ('eu-west', 'local', 'cached', 50.84, 43);
INSERT INTO stream_events (token, label, state, weight, level) VALUES ('stable', 'strict', 'open', 40.86, 19);
