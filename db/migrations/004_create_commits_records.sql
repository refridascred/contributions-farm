-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, level, active, weight) VALUES (45.56, 47, 48, 4.75);
INSERT INTO commits_records (score, level, active, weight) VALUES (53.15, 81, 29, 71.09);
