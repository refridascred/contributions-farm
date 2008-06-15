-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (region, weight, level) VALUES ('local', 49.19, 2);
INSERT INTO layout_items (region, weight, level) VALUES ('green', 91.77, 99);
INSERT INTO layout_items (region, weight, level) VALUES ('standard', 65.8, 31);
