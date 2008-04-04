-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (weight, region, level, ratio) VALUES (52.93, 'standard', 66, 1.77);
INSERT INTO layout_items (weight, region, level, ratio) VALUES (93.44, 'eu-west', 70, 58.43);
