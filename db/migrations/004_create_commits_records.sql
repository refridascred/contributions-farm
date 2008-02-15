-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (token, score, owner, active) VALUES ('stable', 97.51, 'stable', 85);
INSERT INTO commits_records (token, score, owner, active) VALUES ('primary', 0.32, 'green', 60);
INSERT INTO commits_records (token, score, owner, active) VALUES ('blue', 82.06, 'open', 47);
