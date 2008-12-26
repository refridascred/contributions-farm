-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (token, active, owner, ratio, level) VALUES ('open', 47, 'eu-west', 11.78, 22);
INSERT INTO commits_records (token, active, owner, ratio, level) VALUES ('latest', 23, 'legacy', 92.12, 32);
