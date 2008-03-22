-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (weight, rank, ratio) VALUES (11.71, 97, 90.32);
INSERT INTO layout_items (weight, rank, ratio) VALUES (52.17, 38, 89.63);
INSERT INTO layout_items (weight, rank, ratio) VALUES (65.67, 38, 9.93);
