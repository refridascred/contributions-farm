-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (rank, ratio, label, level) VALUES (70, 51.25, 'strict', 90);
INSERT INTO commits_records (rank, ratio, label, level) VALUES (36, 90.72, 'strict', 37);
INSERT INTO commits_records (rank, ratio, label, level) VALUES (52, 24.19, 'open', 49);
