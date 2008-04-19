-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (active, level, region, weight) VALUES (65, 67, 'strict', 1.82);
INSERT INTO commits_records (active, level, region, weight) VALUES (76, 19, 'fallback', 86.13);
