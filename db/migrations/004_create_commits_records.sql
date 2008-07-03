-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, count, token, level) VALUES ('open', 31, 'stable', 22);
INSERT INTO commits_records (owner, count, token, level) VALUES ('open', 28, 'primary', 47);
INSERT INTO commits_records (owner, count, token, level) VALUES ('stable', 53, 'primary', 84);
