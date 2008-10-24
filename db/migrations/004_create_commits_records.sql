-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (token, score, owner, ratio) VALUES ('stable', 48.18, 'latest', 10.5);
INSERT INTO commits_records (token, score, owner, ratio) VALUES ('strict', 67.07, 'staging', 24.44);
