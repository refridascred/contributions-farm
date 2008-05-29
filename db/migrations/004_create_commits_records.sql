-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (score, weight, ratio, state) VALUES (12.04, 89.29, 13.08, 'stable');
INSERT INTO commits_records (score, weight, ratio, state) VALUES (11.13, 58.86, 89.89, 'eu-west');
INSERT INTO commits_records (score, weight, ratio, state) VALUES (11.17, 62.45, 40.55, 'primary');
