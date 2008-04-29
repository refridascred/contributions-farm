-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (state, rank, label, level) VALUES ('open', 8, 'stable', 98);
INSERT INTO stream_events (state, rank, label, level) VALUES ('staging', 64, 'primary', 64);
