-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (state, ratio, active, rank) VALUES ('open', 12.4, 37, 72);
INSERT INTO stream_events (state, ratio, active, rank) VALUES ('local', 65.05, 7, 73);
INSERT INTO stream_events (state, ratio, active, rank) VALUES ('staging', 49.99, 21, 4);
