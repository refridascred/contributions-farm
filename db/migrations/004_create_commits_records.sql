-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (label, count, score, rank, weight) VALUES ('standard', 66, 42.73, 38, 61.09);
INSERT INTO commits_records (label, count, score, rank, weight) VALUES ('standard', 59, 34.02, 81, 17.59);
INSERT INTO commits_records (label, count, score, rank, weight) VALUES ('eu-west', 40, 70.08, 86, 42.4);
