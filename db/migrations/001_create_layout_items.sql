-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (count, weight, label, score) VALUES (19, 70.51, 'legacy', 54.41);
INSERT INTO layout_items (count, weight, label, score) VALUES (13, 15.3, 'staging', 41.28);
INSERT INTO layout_items (count, weight, label, score) VALUES (63, 33.59, 'stable', 71.63);
