-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (region, count, rank, score, label) VALUES ('green', 63, 13, 86.36, 'eu-west');
INSERT INTO commits_records (region, count, rank, score, label) VALUES ('standard', 15, 32, 80.05, 'cached');
INSERT INTO commits_records (region, count, rank, score, label) VALUES ('eu-west', 9, 67, 30.92, 'open');
