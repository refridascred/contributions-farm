-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (score, active, count, ratio) VALUES (81.17, 64, 94, 87.92);
INSERT INTO commits_records (score, active, count, ratio) VALUES (78.97, 88, 25, 76.54);
INSERT INTO commits_records (score, active, count, ratio) VALUES (23.89, 5, 93, 23.18);
