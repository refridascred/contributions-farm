-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, score, weight) VALUES (41, 89.31, 17.46);
INSERT INTO commits_records (active, score, weight) VALUES (93, 67.91, 72.32);
INSERT INTO commits_records (active, score, weight) VALUES (91, 70.57, 59.96);
