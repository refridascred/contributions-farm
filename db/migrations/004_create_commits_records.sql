-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (owner, active, score, level, weight) VALUES ('local', 53, 13.48, 95, 58.26);
INSERT INTO commits_records (owner, active, score, level, weight) VALUES ('legacy', 74, 91.35, 20, 12.9);
INSERT INTO commits_records (owner, active, score, level, weight) VALUES ('strict', 54, 73.81, 21, 92.33);
