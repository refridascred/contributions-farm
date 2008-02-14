-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, owner, ratio, label) VALUES (89.41, 'staging', 1.2, 'primary');
INSERT INTO layout_items (score, owner, ratio, label) VALUES (11.39, 'standard', 82.44, 'legacy');
INSERT INTO layout_items (score, owner, ratio, label) VALUES (24.69, 'local', 58.88, 'stable');
