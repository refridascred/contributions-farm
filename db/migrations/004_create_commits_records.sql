-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (ratio, label, rank, weight) VALUES (84.9, 'fallback', 97, 52.25);
INSERT INTO commits_records (ratio, label, rank, weight) VALUES (73.08, 'fallback', 64, 65.47);
INSERT INTO commits_records (ratio, label, rank, weight) VALUES (43.81, 'latest', 92, 84.84);
