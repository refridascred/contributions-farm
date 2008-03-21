-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, token, owner) VALUES (46.48, 'strict', 'local');
INSERT INTO commits_records (weight, token, owner) VALUES (24.31, 'blue', 'latest');
