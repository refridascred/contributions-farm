-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, weight, rank, score) VALUES ('eu-west', 72.95, 68, 60.66);
INSERT INTO commits_records (label, weight, rank, score) VALUES ('latest', 61.22, 88, 2.88);
INSERT INTO commits_records (label, weight, rank, score) VALUES ('green', 22.61, 17, 48.15);
