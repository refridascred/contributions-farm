-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (rank, label, count, weight) VALUES (0, 'open', 26, 90.35);
INSERT INTO commits_records (rank, label, count, weight) VALUES (85, 'standard', 44, 71.18);
INSERT INTO commits_records (rank, label, count, weight) VALUES (20, 'eu-west', 14, 54.65);
