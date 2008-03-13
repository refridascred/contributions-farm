-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (weight, owner, label, rank) VALUES (98.07, 'strict', 'green', 13);
INSERT INTO commits_records (weight, owner, label, rank) VALUES (61.09, 'blue', 'strict', 73);
