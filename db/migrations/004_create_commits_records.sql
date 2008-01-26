-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    created_at TIMESTAMP,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (owner, weight, level, ratio) VALUES ('legacy', 14.81, 89, 94.05);
INSERT INTO commits_records (owner, weight, level, ratio) VALUES ('blue', 9.31, 1, 67.61);
INSERT INTO commits_records (owner, weight, level, ratio) VALUES ('cached', 24.31, 60, 53.35);
