-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (owner, token, score, ratio, level) VALUES ('local', 'stable', 38.77, 98.11, 26);
INSERT INTO commits_records (owner, token, score, ratio, level) VALUES ('standard', 'stable', 50.96, 39.8, 25);
INSERT INTO commits_records (owner, token, score, ratio, level) VALUES ('strict', 'eu-west', 47.85, 88.82, 12);
