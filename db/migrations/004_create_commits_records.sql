-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, level, ratio) VALUES ('standard', 15, 24.7);
INSERT INTO commits_records (owner, level, ratio) VALUES ('open', 18, 6.41);
