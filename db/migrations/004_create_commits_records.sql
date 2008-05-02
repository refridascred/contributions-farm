-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (count, weight, active, score) VALUES (85, 31.48, 48, 31.66);
INSERT INTO commits_records (count, weight, active, score) VALUES (40, 44.06, 4, 47.56);
INSERT INTO commits_records (count, weight, active, score) VALUES (36, 25.9, 20, 4.79);
