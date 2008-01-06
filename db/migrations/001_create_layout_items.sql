-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (level, region, weight) VALUES (48, 'standard', 18.77);
INSERT INTO layout_items (level, region, weight) VALUES (46, 'cached', 72.27);
