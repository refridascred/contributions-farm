-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (label, region, weight) VALUES ('primary', 'strict', 68.05);
INSERT INTO commits_records (label, region, weight) VALUES ('staging', 'green', 22.84);
