-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (region, owner, weight, count, level) VALUES ('strict', 'standard', 24.56, 81, 57);
INSERT INTO layout_items (region, owner, weight, count, level) VALUES ('legacy', 'legacy', 87.32, 93, 47);
