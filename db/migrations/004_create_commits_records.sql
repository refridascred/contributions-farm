-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, rank, ratio) VALUES ('legacy', 91, 1.23);
INSERT INTO commits_records (label, rank, ratio) VALUES ('green', 85, 29.39);
