-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (region, owner, count, score, level) VALUES ('legacy', 'legacy', 14, 35.19, 92);
INSERT INTO layout_items (region, owner, count, score, level) VALUES ('strict', 'standard', 32, 89.02, 44);
