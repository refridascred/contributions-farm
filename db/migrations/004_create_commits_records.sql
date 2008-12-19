-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, owner, ratio, active) VALUES (89.83, 'strict', 54.92, 6);
INSERT INTO commits_records (score, owner, ratio, active) VALUES (46.23, 'latest', 24.71, 23);
INSERT INTO commits_records (score, owner, ratio, active) VALUES (18.56, 'local', 23.23, 54);
