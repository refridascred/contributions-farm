-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (region, weight, active) VALUES ('standard', 53.88, 28);
INSERT INTO commits_records (region, weight, active) VALUES ('blue', 64.69, 91);
INSERT INTO commits_records (region, weight, active) VALUES ('strict', 80.73, 13);
