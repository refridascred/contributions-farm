-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (label, state, count, weight) VALUES ('cached', 'green', 52, 42.7);
INSERT INTO commits_records (label, state, count, weight) VALUES ('stable', 'open', 21, 76.59);
INSERT INTO commits_records (label, state, count, weight) VALUES ('green', 'eu-west', 57, 41.26);
