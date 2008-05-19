-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (active, level, weight) VALUES (2, 57, 41.29);
INSERT INTO commits_records (active, level, weight) VALUES (59, 12, 67.01);
INSERT INTO commits_records (active, level, weight) VALUES (17, 72, 69.55);
