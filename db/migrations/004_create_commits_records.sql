-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, rank, level, ratio) VALUES (91.35, 75, 88, 4.65);
INSERT INTO commits_records (score, rank, level, ratio) VALUES (57.62, 45, 45, 65.94);
INSERT INTO commits_records (score, rank, level, ratio) VALUES (61.84, 99, 98, 53.79);
