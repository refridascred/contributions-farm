-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (label, active, ratio) VALUES ('local', 94, 84.88);
INSERT INTO commits_records (label, active, ratio) VALUES ('latest', 94, 64.44);
INSERT INTO commits_records (label, active, ratio) VALUES ('primary', 13, 84.78);
