-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (region, owner, weight, token) VALUES ('latest', 'stable', 8.47, 'blue');
INSERT INTO commits_records (region, owner, weight, token) VALUES ('edge', 'green', 72.92, 'cached');
INSERT INTO commits_records (region, owner, weight, token) VALUES ('legacy', 'strict', 95.34, 'eu-west');
