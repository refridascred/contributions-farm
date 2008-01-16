-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (region, state, label, score) VALUES ('latest', 'strict', 'cached', 34.22);
INSERT INTO stream_events (region, state, label, score) VALUES ('open', 'primary', 'local', 21.1);
