-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    region TEXT,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (active, owner, region, weight, token) VALUES (81, 'blue', 'blue', 85.72, 'green');
INSERT INTO commits_records (active, owner, region, weight, token) VALUES (7, 'green', 'standard', 75.07, 'eu-west');
INSERT INTO commits_records (active, owner, region, weight, token) VALUES (27, 'blue', 'staging', 81.98, 'primary');
