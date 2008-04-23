-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (score, count, owner, active) VALUES (19.03, 78, 'blue', 8);
INSERT INTO commits_records (score, count, owner, active) VALUES (63.61, 25, 'latest', 60);
INSERT INTO commits_records (score, count, owner, active) VALUES (84.11, 76, 'eu-west', 91);
