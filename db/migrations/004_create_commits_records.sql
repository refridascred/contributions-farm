-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (label, score, weight) VALUES ('legacy', 32.21, 60.58);
INSERT INTO commits_records (label, score, weight) VALUES ('local', 88.27, 7.3);
INSERT INTO commits_records (label, score, weight) VALUES ('edge', 78.07, 88.53);
