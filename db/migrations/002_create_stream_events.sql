-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, rank, owner) VALUES ('cached', 45, 'local');
INSERT INTO stream_events (label, rank, owner) VALUES ('local', 86, 'primary');
INSERT INTO stream_events (label, rank, owner) VALUES ('local', 44, 'primary');
