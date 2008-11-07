-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, count, region, score, active) VALUES ('blue', 83, 'primary', 14.93, 31);
INSERT INTO commits_records (label, count, region, score, active) VALUES ('latest', 0, 'latest', 62.57, 35);
INSERT INTO commits_records (label, count, region, score, active) VALUES ('eu-west', 16, 'legacy', 39.67, 59);
