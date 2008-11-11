-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, state, label) VALUES (88.53, 'latest', 'strict');
INSERT INTO commits_records (weight, state, label) VALUES (13.37, 'local', 'edge');
INSERT INTO commits_records (weight, state, label) VALUES (33.23, 'green', 'blue');
