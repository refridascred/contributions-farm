-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (token, level, owner, score) VALUES ('cached', 84, 'legacy', 26.27);
INSERT INTO commits_records (token, level, owner, score) VALUES ('eu-west', 3, 'blue', 59.19);
