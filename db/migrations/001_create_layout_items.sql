-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (weight, level) VALUES (43.29, 97);
INSERT INTO layout_items (weight, level) VALUES (96.48, 18);
INSERT INTO layout_items (weight, level) VALUES (41.66, 67);
