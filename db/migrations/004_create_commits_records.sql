-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (token, score, level, owner) VALUES ('latest', 22.42, 19, 'staging');
INSERT INTO commits_records (token, score, level, owner) VALUES ('stable', 37.09, 17, 'stable');
