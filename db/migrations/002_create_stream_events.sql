-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, rank, owner) VALUES ('eu-west', 46, 'legacy');
INSERT INTO stream_events (label, rank, owner) VALUES ('staging', 20, 'blue');
