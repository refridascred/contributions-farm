-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (level, score, token, label, owner) VALUES (47, 20.98, 'edge', 'stable', 'staging');
INSERT INTO commits_records (level, score, token, label, owner) VALUES (57, 54.8, 'green', 'latest', 'green');
INSERT INTO commits_records (level, score, token, label, owner) VALUES (23, 83.22, 'latest', 'primary', 'stable');
