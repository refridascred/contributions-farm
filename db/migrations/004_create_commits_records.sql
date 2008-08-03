-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (region, rank, label, weight) VALUES ('stable', 99, 'strict', 35.11);
INSERT INTO commits_records (region, rank, label, weight) VALUES ('primary', 2, 'standard', 93.0);
INSERT INTO commits_records (region, rank, label, weight) VALUES ('cached', 22, 'standard', 63.59);
