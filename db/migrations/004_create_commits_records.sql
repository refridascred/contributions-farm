-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (active, weight, label, score) VALUES (98, 98.87, 'stable', 38.57);
INSERT INTO commits_records (active, weight, label, score) VALUES (87, 13.3, 'local', 63.79);
INSERT INTO commits_records (active, weight, label, score) VALUES (36, 84.03, 'latest', 49.15);
