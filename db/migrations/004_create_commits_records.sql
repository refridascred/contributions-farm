-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, active, state, weight, count) VALUES (29.38, 66, 'fallback', 46.3, 74);
INSERT INTO commits_records (ratio, active, state, weight, count) VALUES (38.6, 17, 'primary', 14.51, 0);
INSERT INTO commits_records (ratio, active, state, weight, count) VALUES (50.3, 49, 'green', 54.89, 65);
