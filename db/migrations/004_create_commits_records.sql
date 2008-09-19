-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (label, weight, score, active, level) VALUES ('latest', 12.89, 44.17, 16, 43);
INSERT INTO commits_records (label, weight, score, active, level) VALUES ('strict', 79.6, 51.64, 48, 84);
INSERT INTO commits_records (label, weight, score, active, level) VALUES ('standard', 69.01, 63.46, 83, 0);
