-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (label, level, weight, score) VALUES ('edge', 83, 37.67, 58.35);
INSERT INTO commits_records (label, level, weight, score) VALUES ('strict', 49, 13.89, 64.82);
