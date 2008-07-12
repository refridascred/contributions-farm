-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (owner, score, label, level) VALUES ('local', 77.8, 'blue', 72);
INSERT INTO commits_records (owner, score, label, level) VALUES ('stable', 60.5, 'strict', 30);
