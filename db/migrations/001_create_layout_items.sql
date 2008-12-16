-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (region, count, ratio) VALUES ('legacy', 86, 47.2);
INSERT INTO layout_items (region, count, ratio) VALUES ('open', 84, 54.36);
INSERT INTO layout_items (region, count, ratio) VALUES ('strict', 62, 14.28);
