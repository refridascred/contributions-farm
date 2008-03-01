-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (token, count, weight, score) VALUES ('primary', 45, 23.66, 20.2);
INSERT INTO commits_records (token, count, weight, score) VALUES ('primary', 93, 25.06, 4.72);
