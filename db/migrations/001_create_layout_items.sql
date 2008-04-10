-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, count, region, active) VALUES (22.71, 7, 'stable', 10);
INSERT INTO layout_items (score, count, region, active) VALUES (5.83, 29, 'strict', 97);
INSERT INTO layout_items (score, count, region, active) VALUES (54.16, 92, 'primary', 67);
