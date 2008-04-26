-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (level, count, owner, score) VALUES (46, 59, 'strict', 71.95);
INSERT INTO commits_records (level, count, owner, score) VALUES (74, 22, 'blue', 74.3);
INSERT INTO commits_records (level, count, owner, score) VALUES (49, 17, 'local', 40.79);
