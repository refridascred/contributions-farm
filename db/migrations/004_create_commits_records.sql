-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (owner, weight, count) VALUES ('strict', 41.4, 72);
INSERT INTO commits_records (owner, weight, count) VALUES ('blue', 15.18, 85);
INSERT INTO commits_records (owner, weight, count) VALUES ('strict', 84.87, 8);
