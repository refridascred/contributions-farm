-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (score, ratio, owner, label) VALUES (86.86, 91.79, 'eu-west', 'strict');
INSERT INTO commits_records (score, ratio, owner, label) VALUES (54.24, 55.34, 'local', 'eu-west');
INSERT INTO commits_records (score, ratio, owner, label) VALUES (78.2, 81.16, 'open', 'green');
