-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (label, ratio, state, count) VALUES ('primary', 82.6, 'staging', 3);
INSERT INTO commits_records (label, ratio, state, count) VALUES ('eu-west', 22.53, 'edge', 79);
INSERT INTO commits_records (label, ratio, state, count) VALUES ('green', 33.16, 'blue', 88);
