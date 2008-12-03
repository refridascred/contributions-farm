-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    ratio REAL,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, ratio, owner, rank) VALUES (14.07, 90.62, 'green', 85);
INSERT INTO commits_records (weight, ratio, owner, rank) VALUES (70.02, 38.52, 'stable', 19);
INSERT INTO commits_records (weight, ratio, owner, rank) VALUES (95.46, 57.07, 'eu-west', 29);
