-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (level, score, weight) VALUES (24, 60.26, 35.98);
INSERT INTO commits_records (level, score, weight) VALUES (69, 38.6, 96.55);
INSERT INTO commits_records (level, score, weight) VALUES (57, 42.02, 26.77);
