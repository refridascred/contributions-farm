-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, label, rank) VALUES (8.64, 'primary', 67);
INSERT INTO commits_records (weight, label, rank) VALUES (51.24, 'strict', 31);
