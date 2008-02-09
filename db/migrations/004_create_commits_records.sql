-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (token, owner, active, score, count) VALUES ('primary', 'staging', 87, 40.78, 78);
INSERT INTO commits_records (token, owner, active, score, count) VALUES ('open', 'blue', 47, 98.86, 15);
INSERT INTO commits_records (token, owner, active, score, count) VALUES ('latest', 'staging', 48, 24.76, 10);
