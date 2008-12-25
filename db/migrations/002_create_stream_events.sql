-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (token, count, state, ratio) VALUES ('stable', 39, 'primary', 32.96);
INSERT INTO stream_events (token, count, state, ratio) VALUES ('legacy', 46, 'green', 40.97);
