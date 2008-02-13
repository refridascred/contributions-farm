-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (rank, label, token) VALUES (73, 'standard', 'stable');
INSERT INTO stream_events (rank, label, token) VALUES (33, 'stable', 'blue');
INSERT INTO stream_events (rank, label, token) VALUES (40, 'open', 'primary');
