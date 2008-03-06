-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (score, label, weight, rank) VALUES (56.17, 'open', 17.03, 95);
INSERT INTO commits_records (score, label, weight, rank) VALUES (52.08, 'primary', 84.14, 59);
INSERT INTO commits_records (score, label, weight, rank) VALUES (56.04, 'strict', 18.49, 69);
