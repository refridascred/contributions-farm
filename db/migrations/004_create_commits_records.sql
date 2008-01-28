-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (region, label, rank, weight) VALUES ('open', 'open', 84, 25.84);
INSERT INTO commits_records (region, label, rank, weight) VALUES ('open', 'legacy', 10, 26.99);
