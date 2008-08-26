-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (owner, state, weight, score, label) VALUES ('legacy', 'staging', 35.47, 57.01, 'local');
INSERT INTO commits_records (owner, state, weight, score, label) VALUES ('fallback', 'legacy', 18.21, 83.15, 'fallback');
INSERT INTO commits_records (owner, state, weight, score, label) VALUES ('latest', 'staging', 67.76, 50.12, 'local');
