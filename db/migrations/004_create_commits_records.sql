-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (weight, state, ratio, owner) VALUES (72.08, 'green', 98.64, 'eu-west');
INSERT INTO commits_records (weight, state, ratio, owner) VALUES (11.6, 'legacy', 46.37, 'edge');
INSERT INTO commits_records (weight, state, ratio, owner) VALUES (28.11, 'cached', 29.96, 'local');
