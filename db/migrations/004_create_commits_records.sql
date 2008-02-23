-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (ratio, active, token, weight, owner) VALUES (64.03, 68, 'staging', 16.6, 'latest');
INSERT INTO commits_records (ratio, active, token, weight, owner) VALUES (53.28, 99, 'latest', 47.49, 'latest');
INSERT INTO commits_records (ratio, active, token, weight, owner) VALUES (58.02, 31, 'blue', 73.83, 'stable');
