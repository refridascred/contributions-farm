-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (region, level, weight) VALUES ('green', 70, 61.84);
INSERT INTO commits_records (region, level, weight) VALUES ('strict', 21, 58.84);
