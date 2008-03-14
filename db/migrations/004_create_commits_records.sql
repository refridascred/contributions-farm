-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (token, owner, count, score, level) VALUES ('edge', 'local', 32, 74.64, 6);
INSERT INTO commits_records (token, owner, count, score, level) VALUES ('strict', 'blue', 64, 83.51, 45);
INSERT INTO commits_records (token, owner, count, score, level) VALUES ('primary', 'green', 93, 72.86, 68);
