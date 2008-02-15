-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    label TEXT,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (owner, weight, label, region, score) VALUES ('open', 2.3, 'eu-west', 'edge', 82.96);
INSERT INTO commits_records (owner, weight, label, region, score) VALUES ('blue', 29.16, 'stable', 'cached', 23.33);
INSERT INTO commits_records (owner, weight, label, region, score) VALUES ('open', 66.72, 'edge', 'cached', 31.77);
