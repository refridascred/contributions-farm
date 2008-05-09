-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, label, active, ratio) VALUES ('cached', 'standard', 76, 80.18);
INSERT INTO stream_events (state, label, active, ratio) VALUES ('fallback', 'green', 30, 72.79);
