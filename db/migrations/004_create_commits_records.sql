-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (label, ratio, score) VALUES ('primary', 5.05, 30.87);
INSERT INTO commits_records (label, ratio, score) VALUES ('stable', 31.67, 90.84);
INSERT INTO commits_records (label, ratio, score) VALUES ('open', 92.93, 18.66);
