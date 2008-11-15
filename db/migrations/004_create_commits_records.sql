-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, active, level) VALUES ('primary', 74, 18);
INSERT INTO commits_records (label, active, level) VALUES ('strict', 63, 35);
INSERT INTO commits_records (label, active, level) VALUES ('stable', 13, 17);
