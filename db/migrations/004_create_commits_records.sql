-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (token, weight, owner) VALUES ('local', 23.23, 'cached');
INSERT INTO commits_records (token, weight, owner) VALUES ('staging', 39.0, 'stable');
INSERT INTO commits_records (token, weight, owner) VALUES ('open', 20.99, 'latest');
