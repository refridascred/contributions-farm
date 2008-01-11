-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (weight, label, rank, score) VALUES (98.91, 'staging', 18, 69.13);
INSERT INTO commits_records (weight, label, rank, score) VALUES (0.78, 'blue', 26, 33.02);
INSERT INTO commits_records (weight, label, rank, score) VALUES (13.84, 'open', 53, 25.1);
