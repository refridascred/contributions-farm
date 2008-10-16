-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (owner, score, level) VALUES ('open', 47.64, 93);
INSERT INTO commits_records (owner, score, level) VALUES ('fallback', 13.25, 85);
INSERT INTO commits_records (owner, score, level) VALUES ('eu-west', 17.37, 12);
