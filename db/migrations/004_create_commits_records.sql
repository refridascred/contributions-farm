-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (token, level, score, owner, ratio) VALUES ('strict', 69, 8.01, 'open', 34.99);
INSERT INTO commits_records (token, level, score, owner, ratio) VALUES ('green', 17, 28.28, 'standard', 53.18);
INSERT INTO commits_records (token, level, score, owner, ratio) VALUES ('stable', 55, 3.71, 'local', 72.23);
