-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (score, count, active, ratio) VALUES (13.06, 44, 28, 26.93);
INSERT INTO commits_records (score, count, active, ratio) VALUES (71.62, 67, 41, 92.01);
INSERT INTO commits_records (score, count, active, ratio) VALUES (73.79, 10, 37, 83.87);
