-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (label, ratio, level, state, rank) VALUES ('green', 84.62, 19, 'fallback', 73);
INSERT INTO stream_events (label, ratio, level, state, rank) VALUES ('legacy', 63.74, 15, 'latest', 93);
INSERT INTO stream_events (label, ratio, level, state, rank) VALUES ('staging', 40.93, 4, 'standard', 74);
