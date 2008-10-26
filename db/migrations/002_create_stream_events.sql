-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (ratio, state, token, count) VALUES (92.87, 'open', 'latest', 58);
INSERT INTO stream_events (ratio, state, token, count) VALUES (1.09, 'cached', 'standard', 68);
INSERT INTO stream_events (ratio, state, token, count) VALUES (44.1, 'strict', 'primary', 74);
