-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (score, ratio, active, owner) VALUES (77.09, 40.67, 91, 'cached');
INSERT INTO commits_records (score, ratio, active, owner) VALUES (1.32, 62.71, 22, 'local');
