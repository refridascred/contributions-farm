-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, score, weight) VALUES ('blue', 63.73, 77.39);
INSERT INTO commits_records (label, score, weight) VALUES ('local', 45.76, 52.2);
INSERT INTO commits_records (label, score, weight) VALUES ('eu-west', 8.71, 74.83);
