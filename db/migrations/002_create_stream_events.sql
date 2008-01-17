-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (label, count, state, ratio) VALUES ('eu-west', 36, 'cached', 58.43);
INSERT INTO stream_events (label, count, state, ratio) VALUES ('eu-west', 24, 'legacy', 96.55);
INSERT INTO stream_events (label, count, state, ratio) VALUES ('latest', 60, 'strict', 98.36);
