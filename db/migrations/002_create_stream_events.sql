-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (level, score, state) VALUES (92, 25.25, 'standard');
INSERT INTO stream_events (level, score, state) VALUES (57, 68.74, 'open');
INSERT INTO stream_events (level, score, state) VALUES (38, 67.03, 'eu-west');
