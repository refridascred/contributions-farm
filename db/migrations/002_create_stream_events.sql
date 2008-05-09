-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, rank, owner) VALUES ('cached', 59, 'blue');
INSERT INTO stream_events (label, rank, owner) VALUES ('eu-west', 86, 'cached');
INSERT INTO stream_events (label, rank, owner) VALUES ('green', 94, 'standard');
