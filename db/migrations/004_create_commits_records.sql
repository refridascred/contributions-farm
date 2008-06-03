-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (token, weight, level, score) VALUES ('local', 44.22, 2, 35.19);
INSERT INTO commits_records (token, weight, level, score) VALUES ('open', 35.34, 71, 84.96);
