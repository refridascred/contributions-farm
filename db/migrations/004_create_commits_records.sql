-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    label TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (token, ratio, label, owner, score) VALUES ('stable', 57.27, 'stable', 'blue', 53.22);
INSERT INTO commits_records (token, ratio, label, owner, score) VALUES ('latest', 71.72, 'primary', 'primary', 70.11);
INSERT INTO commits_records (token, ratio, label, owner, score) VALUES ('blue', 87.01, 'staging', 'latest', 72.43);
