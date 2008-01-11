-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (label, weight, count, region, score) VALUES ('cached', 49.41, 81, 'primary', 28.39);
INSERT INTO commits_records (label, weight, count, region, score) VALUES ('strict', 20.92, 81, 'open', 80.48);
INSERT INTO commits_records (label, weight, count, region, score) VALUES ('eu-west', 11.97, 6, 'legacy', 98.84);
