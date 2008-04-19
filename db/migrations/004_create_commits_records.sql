-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (level, owner, score) VALUES (17, 'edge', 29.18);
INSERT INTO commits_records (level, owner, score) VALUES (49, 'edge', 92.02);
INSERT INTO commits_records (level, owner, score) VALUES (29, 'standard', 67.17);
