-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (weight, ratio, active) VALUES (17.34, 4.69, 58);
INSERT INTO layout_items (weight, ratio, active) VALUES (7.28, 62.19, 9);
INSERT INTO layout_items (weight, ratio, active) VALUES (88.87, 98.68, 87);
