-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, rank, owner, state) VALUES ('strict', 93, 'eu-west', 'green');
INSERT INTO stream_events (label, rank, owner, state) VALUES ('standard', 88, 'stable', 'legacy');
INSERT INTO stream_events (label, rank, owner, state) VALUES ('cached', 35, 'eu-west', 'stable');
